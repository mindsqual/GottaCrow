using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GottaCrowWebUI.Entities
{
    public interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; }

        List<IEmail> Emails { get; set; }
        List<IPhoneNumber> PhoneNumbers { get; set; }
    }
    public class Person : IPerson
    {
        private List<IEmail> _emails;
        private List<IPhoneNumber> _phoneNumbers;

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        [NotMapped]
        public List<IEmail> Emails
        {
            get { return _emails; }
            set { _emails = value; }
        }

        [NotMapped]
        public List<IPhoneNumber> PhoneNumbers
        {
            get { return _phoneNumbers; }
            set { _phoneNumbers = value; }
        }
    }
}
