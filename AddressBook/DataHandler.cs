using System.Collections.Generic;
using System.IO;

namespace AddressBook
{
    public class DataHandler
    {
        public string PathToTextFile
        {
            get { return @"C:\Users\Maria\Documents\addressbook.txt"; }
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
    }
}
