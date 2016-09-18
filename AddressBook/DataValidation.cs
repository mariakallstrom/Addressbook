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
                if (t.Contains(obj.Email))
                {
                    count++;
                }
            }
            if (count == 0)
            {
                return true;
            }
            MessageBox.Show(@"Kontakten finns redan!");
            return false;
        }

        public bool ControlEmptyTextBoxes(Contact obj)
        {
            string[] textBoxArray = { obj.FirstName, obj.LastName, obj.Phone, obj.Email };
            int count = 0;

            foreach (string text in textBoxArray)
            {
                if (text == "")
                {
                    count++;
                }
            }
            if (count == 0)
            {
                return true;
            }
            MessageBox.Show(@"Du måste fylla i förnamn, efternamn, telefon och email");
            return false;
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
                MessageBox.Show(@"Felaktigt Telefonnummer");
                return false;
            }
            return true;
        }
    }
}
