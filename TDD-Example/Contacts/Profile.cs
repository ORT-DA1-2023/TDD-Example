using System;

namespace Contacts
{
    public class Profile
    {
        private const int FirstNameMaxLenght = 30;
        private string firstName;
        public Profile()
        {
        }

        public string FirstName { get => firstName; set {
                if(value.Length > FirstNameMaxLenght)
                {
                    throw new BusinessLogicException($"Invalid first name: {value} is too long");
                }
                firstName = value;
            } }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string StreetAddress { get; set; }
        public string PicturePath { get; set; }
    }
}