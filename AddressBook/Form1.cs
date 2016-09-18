using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        DataHandler data = new DataHandler();

        public Form1()
        {
            InitializeComponent();
        }
        private void BtnRegistrate_Click(object sender, EventArgs e)
        {
            DataValidation val = new DataValidation();
            Contact obj = new Contact(TxtFirstName.Text, TxtLastName.Text, TxtAddress.Text, TxtZip.Text, TxtCity.Text,
            TxtPhone.Text, TxtEmail.Text);
           
            if (val.ControlEmptyTextBoxes(obj) && val.FixText(obj) && val.ControlPhone(obj) && val.ControlContactExist(obj))
            {
                data.WriteData(obj);
                ClearForm();
                GetDataToListBox();
            }
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
            Contact obj = new Contact(TxtFirstName.Text, TxtLastName.Text, TxtAddress.Text, TxtZip.Text, TxtCity.Text,
                TxtPhone.Text, TxtEmail.Text);
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
        private void ListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SplitListToTextBox();
        }
        public void SearchContact()
        {
            var list = data.ReadData().ToArray();
            if (TxtSearch.Text == String.Empty)
            {
                MessageBox.Show(@"Kontakten finns inte!");
            }
            else
            {
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
        }
        public void SplitListToTextBox()
        {
            string list = ListBox.SelectedItem.ToString();
            string[] textArray = list.Split(',');

            foreach (var row in list)
            {
                        TxtFirstName.Text = textArray[0];
                        TxtLastName.Text = textArray[1];
                        TxtAddress.Text = textArray[2];
                        TxtZip.Text = textArray[3];
                        TxtCity.Text = textArray[4];
                        TxtPhone.Text = textArray[5];
                        TxtEmail.Text = textArray[6];
            }
        }

        public void DeleteContact()
        {
            if (TxtEmail.Text != "")
            {
            var oldLines = File.ReadAllLines(data.PathToTextFile);
            var newLines = oldLines.Where(line => !line.Contains(TxtEmail.Text));
            File.WriteAllLines(data.PathToTextFile, newLines);
            }
            else
            {
                MessageBox.Show(@"Du måste välja en kontakt att ta bort");
            }
          
        }
        public void GetDataToListBox()
        {
            ListBox.DataSource = data.ReadData();
        }
        public void ClearForm()
        {
            foreach (Control item in Controls)
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
