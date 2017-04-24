using System;

namespace GottaCrowWebUI.Entities
{
    public interface IContact
    {
        int Id { get; set; }
        Person Person { get; set; }
        
    }

    public interface IJobSearchContact : IContact
    {
        JobSearchContactType Type { get; set; }
    }
    
    public class Contact : IContact
    {
        //ctors
        public Contact() { }
        
        public int Id { get; set; }
        
        public Person Person { get; set; }
    }

    public class JobSearchContact : Contact, IJobSearchContact
    {
        public JobSearchContact() {}
        public JobSearchContactType Type { get; set; }
    }
}
