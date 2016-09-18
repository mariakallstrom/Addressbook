using System;
using System.Windows.Forms;

namespace AddressBook
{
    public static class Extension
    {
        
        public static string UpperCaseFirst(this string text)
        {
            if (text == "")
            {
                return text;
            }
            else if (text.Length > 0 && text.Length < 1)
            {
                MessageBox.Show(@"Texten måste vara längre än 2 bokstäver");
                return text;
            }
                return text = char.ToUpper(text[0]) + text.Substring(1);
        }
        public static string LowerString(this string text)
        {
            if (text == "")
            {
                return text;
            }
            else if (text.Length > 0 && text.Length < 1)
            {
                MessageBox.Show(@"Texten måste vara längre än 2 bokstäver");
                return text;
            }

            return text.ToLower();
        }
    }
}
