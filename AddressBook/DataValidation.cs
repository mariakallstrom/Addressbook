using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class DataValidation
    {
        Contact obj = new Contact();
        DataHandler data = new DataHandler();

        public bool ControlContactExist()
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
            else
            {
                MessageBox.Show("Kontakten finns redan!");
                return false;
            }
        }

        public bool ControlEmptyTextBoxes()
        {
            string[] textBoxArray = new string[] { obj.FirstName, obj.LastName, obj.Address, obj.ZipCode, obj.City, obj.Phone, obj.Email };
            int count = 0;
            bool ok = true;

            for (int i = 0; i < textBoxArray.Length; i++)
            {
                if (textBoxArray[i] == "")
                {
                    count++;
                }
            }
            if (count == 0)
            {
                return ok;
            }
            else
            {
                MessageBox.Show("Du måste fylla i alla fält");
                return false;
            }
        }

        public bool ControlZipCode()
        {
            int zip;
            bool ok = int.TryParse(obj.ZipCode, out zip);
            if (ok == false || obj.ZipCode.Length < 5 || obj.ZipCode.Length > 5)
            {
                MessageBox.Show("Felaktigt postnummer");
                return false;
            }
            else
            {
                return ok;
            }
        }

        public bool ControlEmail()
        {
            var emailLength = obj.Email.Length;

            if (obj.Email.Contains("@") && obj.Email.LastIndexOf(".") == (emailLength - 4) ||
                obj.Email.LastIndexOf(".") == (emailLength - 3))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Fel emailaddress!");
                return false;
            }


        }

        public bool ControlPhone()
        {
            int num;
            bool ok = int.TryParse(obj.Phone, out num);
            if (ok == false || obj.Phone.Length < 9 || obj.Phone.Length > 10)
            {
                MessageBox.Show("Felaktigt Telefonnummer");
                return false;
            }
            else
            {
                return ok;
            }
        }
    }
}
