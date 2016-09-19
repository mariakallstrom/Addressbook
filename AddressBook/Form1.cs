﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        DataHandler data = new DataHandler();

        public Form1()
        {
            InitializeComponent();
            WriteToCollection();
        }

        private void BtnRegistrate_Click(object sender, EventArgs e)
        {
            DataValidation val = new DataValidation();
            Contact obj = new Contact(TxtFirstName.Text.Trim().UpperCaseFirst(),
                TxtLastName.Text.Trim().UpperCaseFirst(), TxtAddress.Text.Trim().UpperCaseFirst(), TxtZip.Text.Trim(),
                TxtCity.Text.Trim().UpperCaseFirst(),
                TxtPhone.Text.Trim(), TxtEmail.Text.Trim().LowerString());

            if (val.ControlEmptyTextBoxes(obj) && val.ControlPhone(obj) && val.ControlContactExist(obj) &&
                val.ControlEmail(obj))
            {
                DeleteContact();
                data.WriteData(obj);
                ClearForm();
                GetDataToListBox();
                WriteToCollection();
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void BtnDeleteContact_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(@"Vill du ta bort kontakten?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                DeleteContact();
                GetDataToListBox();
            }
           
        }

        private void ListBox_MouseClick(object sender, MouseEventArgs e)
        {
           
            var text = ListBox.SelectedItem.ToString();
            var list = text.Split(',').ToArray();
                TxtFirstName.Text = list[0];
                TxtLastName.Text = list[1];
                TxtAddress.Text = list[2];
                TxtZip.Text = list[3];
                TxtCity.Text = list[4];
                TxtPhone.Text = list[5];
                TxtEmail.Text = list[6];
        }

        public void SearchContact()
        {
           
            var list = data.ReadData().ToArray();
            var count = 0;
            bool ok = true;

            foreach (var text in list)
            {
                if (!text.Contains(TxtSearch.Text) || text != TxtSearch.SelectedText)
                {
                    count++;
                }

                 if (count == 0)
                {
                    MessageBox.Show(@"Kontakten finns inte");
                }
            }
            if (count != 0)
            {
                foreach (var text in list)
                {
                    if (text == TxtSearch.SelectedText)
                        
                    {
                            list = text.Split(',');
                            TxtFirstName.Text = list[0];
                            TxtLastName.Text = list[1];
                            TxtAddress.Text = list[2];
                            TxtZip.Text = list[3];
                            TxtCity.Text = list[4];
                            TxtPhone.Text = list[5];
                            TxtEmail.Text = list[6];
                            ok = false;
                    }
                }
                if (ok)
                {
                    foreach (var text in list)
                    {
                        list = text.Split(',');

                        if (list.Contains(TxtSearch.Text))
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
     



        public void WriteToCollection()
        {
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            col.Clear();
            string[] list = data.ReadData().ToArray();
            foreach (var line in list)
            {
                TxtSearch.AutoCompleteCustomSource.AddRange(list);
            }
        }

        public void DeleteContact()
        {
            if (TxtEmail.Text != "" || TxtPhone.Text != "")
            {
                var oldLines = File.ReadAllLines(data.PathToTextFile);
                var newLines = oldLines.Where(line => !line.Contains(TxtEmail.Text) && !line.Contains(TxtPhone.Text));
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
                if (item is TextBox)
                {
                    item.Text = "";
                }
                ListBox.DataSource = null;
            }
        }
    }
}
