using System.Collections.Generic;
using System.Windows.Forms;

namespace AddressBook
{
    class DataValidation
    {
        DataHandler data = new DataHandler();

        public bool ControlContactExist(Contact obj)
        {
            List<string> list = data.ReadData();
            string[] listArray = list.ToArray();
            int count = 0;

            foreach (var t in listArray)
            {
                if (t.Contains(obj.Email) || t.Contains(obj.Phone))
                {
                    count++;
                }
            }
            if (count == 0)
            {
                return true;
            }
            DialogResult dr = MessageBox.Show(@"Kontakten finns redan, vill du ändra kontaktuppgifterna?","", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        public bool ControlEmptyTextBoxes(Contact obj)
        {
            string[] textBoxArray = { obj.FirstName, obj.LastName, obj.Phone, obj.Email };

            if (string.IsNullOrWhiteSpace(obj.FirstName) || string.IsNullOrEmpty(obj.LastName) || string.IsNullOrEmpty(obj.Phone) || string.IsNullOrEmpty(obj.Email))
            { 
                var message = "Du måste fylla i: ";

                if (string.IsNullOrWhiteSpace(obj.FirstName))
                {
                    message += "\nFörnamn";
                }
                if (string.IsNullOrEmpty(obj.LastName))
                {
                    message += "\nEfternamn";
                }
                if (string.IsNullOrEmpty(obj.Phone))
                {
                    message += "\nTelefonnummer";
                }
                if (string.IsNullOrEmpty(obj.Email))
                {
                    message += "\nEmail";
                }

                MessageBox.Show(message);
                return false;
            }
            return true;
        }

        public bool ControlEmail(Contact obj)
        {
            var emailLength = obj.Email.Length;

            if (obj.Email.Contains("@") && obj.Email.LastIndexOf(".") == (emailLength - 4) ||
                obj.Email.LastIndexOf(".") == (emailLength - 3))
            {
                return true;
            }
            MessageBox.Show(@"Fel emailaddress!");
            return false;
        }

        public bool ControlPhone(Contact obj)
        {
            int num;
            bool ok = int.TryParse(obj.Phone, out num);
            if (ok == false || obj.Phone.Length < 9 || obj.Phone.Length > 10)
            {
                MessageBox.Show(@"Felaktigt Telefonnummer, måste innehålla 9 eller 10 siffror");
                return false;
            }
            return true;
        }
    }
}
