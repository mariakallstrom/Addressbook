using System;
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
            _Form1 = this;
            data.WriteToCollection();
        }

        public static Form1 _Form1;

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
                data.DeleteContact();
                data.WriteData(obj);
                data.ClearForm();
                data.GetDataToListBox();
                data.WriteToCollection();
            }
        }

        private void BtnGetContact_Click(object sender, EventArgs e)
        {
            data.DeleteEmptyLines();
            data.GetDataToListBox();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
           
            data.SearchContact();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            data.ClearForm();
        }

        private void BtnDeleteContact_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(@"Vill du ta bort kontakten?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                data.DeleteContact();
                data.GetDataToListBox();
              
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


    }
}
