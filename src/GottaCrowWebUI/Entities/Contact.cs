using System;

namespace GottaCrowWebUI.Entities
{
    public enum JobSearchContactType
    {
        Acquaintance, //ie: networking/LinkedIn, etc.
        Recruiter,
        EmployeeHumanResources,
        EmployeeOther,
        EmployeeManager,
    }

    public interface IContact
    {
        int Id { get; set; }
        IPerson Person { get; set; }
        IEmail Email { get; set; }
        IPhoneNumber Phone { get; }
    }

    public interface IJobSearchContact : IContact
    {
        JobSearchContactType Type { get; set; }
    }

    public interface IEmail
    {
        string FullEmail { get; set; }
    }

    public interface IPhoneNumber
    {
        string FullNumber { get; }
    }

    public class Email : IEmail
    {
        public Email(string email)
        {
            FullEmail = email;
        }
        public string FullEmail { get; set; }
    }

    public class PhoneNumber : IPhoneNumber
    {
        
        private readonly string _fullNumber;
        public PhoneNumber(string number)
        {
            //TO-DO: client-side validation and parsing of this string
            //I could have this ctor check the format of the number 
            //and throw exception if not correct...???
            _fullNumber = number;
        }
        public string FullNumber { get { return _fullNumber; } }
    }

    public class Contact : IContact
    {
        private IPhoneNumber _phoneNumber;
        private IPerson _person;
        private IEmail _email;


        //ctors
        public Contact()
        {

        }
        public Contact(IPhoneNumber phone, IPerson person, IEmail email)
        {
            _phoneNumber = phone;
            _person = person;
            _email = email;

        }
        public int Id { get; set; }
        public IPerson Person { get; set; }
        public IEmail Email { get; set; }
        public IPhoneNumber Phone
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
    }

    public class JobSearchContact : Contact, IJobSearchContact
    {
        public JobSearchContact() {}
        public JobSearchContact(IPhoneNumber phone, IPerson person, IEmail email):base(phone,person,email)
        {

        }
        public JobSearchContactType Type { get; set; }
    }
}
