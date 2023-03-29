using Contacts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ContactTests
{
    [TestClass]
    public class ProfileTests
    {
        private const string John = "John";
        private const string Doe = "Doe";
        private readonly DateTime Oct7th1997 = new DateTime(1997, 10, 7);
        private const string PhoneNumberSample = "+59899999999";
        private const string SomeStreetAddress = "SomeStreet 1111";
        private const string PicturePathSample = @"Resources\test-image.jpg";


        [TestMethod]
        public void CreateProfileSuccessTest()
        {
            var profile = new Profile()
            {
                FirstName = John,
                LastName = Doe,
                BirthDate = Oct7th1997,
                PhoneNumber = PhoneNumberSample,
                StreetAddress = SomeStreetAddress,
                PicturePath = PicturePathSample,
            };

            Assert.IsNotNull(profile);
            Assert.AreEqual(profile.FirstName, John);
            Assert.AreEqual(profile.LastName, Doe);
            Assert.AreEqual(profile.BirthDate, Oct7th1997);
            Assert.AreEqual(profile.PhoneNumber, PhoneNumberSample);
            Assert.AreEqual(profile.StreetAddress, SomeStreetAddress);
            Assert.AreEqual(profile.PicturePath, PicturePathSample);

        }


    }
}
