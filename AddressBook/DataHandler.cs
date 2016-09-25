using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AddressBook
{
    public class DataHandler
    {
        public string PathToTextFile
        {
            get { return @"C:\Users\Maria\Desktop\Textdokument.txt"; }
        }

        public void WriteData(Contact obj)
        {
            var path = PathToTextFile;
            DeleteEmptyLines();
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(obj.FirstName + "," + obj.LastName + "," + obj.Address + "," + obj.Zip + "," + obj.City + "," + obj.Phone + "," + obj.Email);
            sw.Close();
        }

        public List<string> ReadData()
        {
            List<string> list = new List<string>();
            var path = PathToTextFile;
            string row = "";
            StreamReader sr = new StreamReader(path, true);
            while ((row = sr.ReadLine()) != null)
            {
                list.Add(row);
            }
            sr.Close();
            return list;
        }
 
        public void DeleteEmptyLines()
        {
            var tempFileName = Path.GetTempFileName();
            try
            {
                using (var sr = new StreamReader(PathToTextFile))
                using (var sw = new StreamWriter(tempFileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                            sw.WriteLine(line);
                    }
                }
                File.Copy(tempFileName, PathToTextFile, true);
            }
            finally
            {
                File.Delete(tempFileName);
            }
        }

        public void SearchContact()
        {
            var list = ReadData();

           var find = list.FindAll(x => x.Contains(Form1._Form1.TxtSearch.Text));

           if (find.Count == 1)
            {
                foreach (var text in find)
                {
                    var split = text.Split(',');
                    Form1._Form1.TxtFirstName.Text = split[0];
                    Form1._Form1.TxtLastName.Text = split[1];
                    Form1._Form1.TxtAddress.Text = split[2];
                    Form1._Form1.TxtZip.Text = split[3];
                    Form1._Form1.TxtCity.Text = split[4];
                    Form1._Form1.TxtPhone.Text = split[5];
                    Form1._Form1.TxtEmail.Text = split[6];
                }
            }
            else if (find.Count == list.Count || find.Count == 0)
            {
                MessageBox.Show(@"kontakten finns inte!");
            }

            else if (find.Count > 1)
            {
                MessageBox.Show(@"Det fler kontakter med liknande uppgifter");
                Form1._Form1.ListBox.DataSource = find;
            }
        }

        public void DeleteContact()
        {
            if (Form1._Form1.TxtEmail.Text != "" || Form1._Form1.TxtPhone.Text != "")
            {
                var oldLines = File.ReadAllLines(PathToTextFile);
                var newLines = oldLines.Where(line => !line.Contains(Form1._Form1.TxtEmail.Text) && !line.Contains(Form1._Form1.TxtPhone.Text));
                File.WriteAllLines(PathToTextFile, newLines);
            }
            else
            {
                MessageBox.Show(@"Du måste välja en kontakt att ta bort");
            }
        }

        public void WriteToCollection()
        {
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            col.Clear();
            string[] list = ReadData().ToArray();
            foreach (var line in list)
            {
                Form1._Form1.TxtSearch.AutoCompleteCustomSource.AddRange(list);
            }
        }

        public void GetDataToListBox()
        {
            Form1._Form1.ListBox.DataSource = ReadData();
        }

        public void ClearForm()
        {
            foreach (Control item in Form1._Form1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                Form1._Form1.ListBox.DataSource = null;
            }
        }
    }
}
