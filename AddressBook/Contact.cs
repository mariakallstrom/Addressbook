using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string SearchContact { get; set; }

        public Contact() //Default
        {

            FirstName = "Maria";
            LastName = "Nilsson";
            Address = "Lingonstigen 5";
            City = "Stockholm";
            Zip = "12345";
            Phone = "0000000000";
            Email = "Maria@maria.se";
        }

        public Contact(string firstName, string lastName, string address, string zip, string city, string phone, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Zip = zip;
            City = city;
            Phone = phone;
            Email = email;
        }

    }
}
