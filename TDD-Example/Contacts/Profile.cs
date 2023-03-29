using System;

namespace Contacts
{
    public class Profile
    {
        public Profile()
        {
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string StreetAddress { get; set; }
        public string PicturePath { get; set; }
    }
}