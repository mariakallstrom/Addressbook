using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        DataHandler data = new DataHandler();
        Contact obj = new Contact();
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnRegistrate_Click(object sender, EventArgs e)
        {
            Contact obj = new Contact();

            obj.FirstName = TxtFirstName.Text.Trim();
            obj.LastName = TxtLastName.Text.Trim();
            obj.Address = TxtAddress.Text.Trim();
            obj.Zip = TxtZip.Text.Trim();
            obj.City = TxtCity.Text.Trim();
            obj.Phone = TxtPhone.Text.Trim();
            obj.Email = TxtEmail.Text.Trim();
            data.WriteData(obj);
            ClearForm();
            GetDataToListBox();
        }
        private void BtnGetContact_Click(object sender, EventArgs e)
        {
           GetDataToListBox();
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchContact();
        }
        private void BtnChange_Click(object sender, EventArgs e)
        {
            DeleteContact();
            obj.FirstName = TxtFirstName.Text.Trim();
            obj.LastName = TxtLastName.Text.Trim();
            obj.Address = TxtAddress.Text.Trim();
            obj.Zip = TxtZip.Text.Trim();
            obj.City = TxtCity.Text.Trim();
            obj.Phone = TxtPhone.Text.Trim();
            obj.Email = TxtEmail.Text.Trim();
            data.WriteData(obj);
            GetDataToListBox();

        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void BtnDeleteContact_Click(object sender, EventArgs e)
        {
            DeleteContact();
           GetDataToListBox();
        }

        public void SearchContact()
        {
            var list = data.ReadData().ToArray();

            foreach (var row in list)
            {
                list = row.Split(',');

                foreach (var word in list)
                {
                    if (word == TxtSearch.Text)
                    {
                        TxtFirstName.Text = list[0];
                        TxtLastName.Text = list[1];
                        TxtAddress.Text = list[2];
                        TxtZip.Text = list[3];
                        TxtCity.Text = list[4];
                        TxtPhone.Text = list[5];
                        TxtEmail.Text = list[6];
                    }
                }

            }
        }

        public void DeleteContact()
        {
            string tempFile = Path.GetTempFileName();

            using (var sr = new StreamReader(data.PathToTextFile))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    if (!line.Contains(TxtEmail.Text))
                        sw.WriteLine(line);
                }
            }

            File.Delete(data.PathToTextFile);
            File.Move(tempFile, data.PathToTextFile);

        }

        public void GetDataToListBox()
        {
            ListBox.DataSource = data.ReadData();
        }
        public void ClearForm()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox )
                {
                    item.Text = "";
                }
                ListBox.DataSource = null;
            }
        }

     
    }
}
