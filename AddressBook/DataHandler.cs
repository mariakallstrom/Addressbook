using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class DataHandler
    {

       
        Contact obj = new Contact();
        DataHandler data = new DataHandler();
        public string PathToTextFile
        {
            get { return @"C:\Users\Maria\Documents\addressbook.txt"; }
        }
        public void WriteData(Contact obj)
        {
            DataHandler data = new DataHandler();
            var path = data.PathToTextFile;
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(obj.FirstName + "," + obj.LastName + "," + obj.Address + "," + obj.Zip + "," + obj.City + "," + obj.Phone + "," + obj.Email);
            sw.Close();
        }
        public List<string> ReadData()
        {
            List<string> list = new List<string>();
            var path = data.PathToTextFile;
            string row = "";
            StreamReader sr = new StreamReader(path, true);
            while ((row = sr.ReadLine()) != null)
            {
                list.Add(row);
            }
            sr.Close();
            return list;
        }
        public void Searchdata(Contact obj)
        {
            List<string> list = ReadData();
            string[] listArray = list.ToArray();


            if (obj.SearchContact == "")
            {
                MessageBox.Show("Kontakten finns inte!");
            }
            else
            {
                foreach (string t in listArray)
                {
                    if (t.Contains(obj.SearchContact))
                    {
                        var wordArray = t.Split(',');

                        for (int i = 0; i < wordArray.Length; i++)
                        {
                            if (i == 0)
                            {
                                obj.Id = wordArray[0];
                            }

                            else if (i == 1)
                            {
                                obj.FirstName = wordArray[1];
                            }
                            else if (i == 2)
                            {
                                obj.LastName = wordArray[2];
                            }
                            else if (i == 3)
                            {
                                obj.Address = wordArray[3];
                            }
                            else if (i == 4)
                            {
                                obj.Zip = wordArray[4];
                            }
                            else if (i == 5)
                            {
                                obj.City = wordArray[5];
                            }

                            else if (i == 6)
                            {
                                obj.Phone = wordArray[6];
                            }
                            else if (i == 7)
                            {
                                obj.Email = wordArray[7];
                            }

                        }
                    }
                }
            }
        }

        public void SplitList()
        {
            string list = ListBox.SelectedItem.ToString();

            string[] textArray = list.Split(',');

            for (int i = 0; i < textArray.Length; i++)
            {

                if (i == 0)
                {
                    obj.Id = textArray[0];
                }

                else if (i == 1)
                {
                    obj.FirstName = textArray[1];
                }
                else if (i == 2)
                {
                    obj.LastName = textArray[2];
                }
                else if (i == 3)
                {
                    obj.Address = textArray[3];
                }
                else if (i == 4)
                {
                    obj.ZipCode = textArray[4];
                }
                else if (i == 5)
                {
                    obj.City = textArray[5];
                }

                else if (i == 6)
                {
                    obj.Phone = textArray[6];
                }
                else
                {
                    obj.Email = textArray[7];
                }
            }
        }

        private void ChangeData(Contact obj)
        {
            //todo
        }
    }
}
