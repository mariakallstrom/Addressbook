using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public static class Extension
    {
        public static string UpperCaseFirst(this string text)
        {
            return char.ToUpper(text[0]) + text.Substring(1);
        }
        public static string LowerString(this string text)
        {
            return text.ToLower();
        }
    }
}
