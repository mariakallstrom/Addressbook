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
           
        }

        public Contact(string firstName, string lastName, string address, string zip, string city, string phone, string email)
        {
            FirstName = firstName.Trim().UpperCaseFirst();
            LastName = lastName.Trim().UpperCaseFirst();
            if (Address != null)
            {
                Address = address.UpperCaseFirst();
            }
            Address = address.Trim();
            Zip = zip.Trim();
            if (City != null)
            {
                City = city.UpperCaseFirst();
            }
            City = city.Trim();
            Phone = phone.Trim();
            Email = email.Trim().LowerString();
        }

    }
}
