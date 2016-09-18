using System;
using System.Windows.Forms;

namespace AddressBook
{
    public static class Extension
    {
        static Contact obj = new Contact();
        public static string UpperCaseFirst(this string text)
        {
            if (text == String.Empty || text.Length == 1)
            {
                MessageBox.Show(@"texten måste vara längre än 2 bokstäver");
            }
            else
            {
                text = char.ToUpper(text[0]) + text.Substring(1);
            }
            return text;



        }
        public static string LowerString(this string text)
        {
            if (text == String.Empty || text.Length == 1)
            {
                MessageBox.Show(@"Texten måste vara längre än 2 bokstäver");
            }
            else
            {
                return text.ToLower();
            }
            return text;
        }
    }
}
