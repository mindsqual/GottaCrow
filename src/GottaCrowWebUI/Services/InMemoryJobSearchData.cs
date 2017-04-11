using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GottaCrowWebUI.Entities;
using GottaCrowWebUI.Utilities;

namespace GottaCrowWebUI.Services
{
    /// <summary>
    /// NOTE: This class is mostly for testing/prototyping
    /// In production this won't fly because List<> is not thread safe
    /// </summary>
    public class InMemoryJobSearchData : IJobSearchActivityData
    {
        private List<JobSearchActivity> _activities;
        private List<Person> _people;
        private List<JobSearchContact> _jobContacts;
        public InMemoryJobSearchData()
        {
            var timeStamp = new DateTimeAdapter().UtcNow;

            _people = new List<Person>
            {
                new Person { Id=100, FirstName="Fred", LastName="Flintstone",
                    Emails = new List<IEmail> { new Email("fred@someCompany.net") },
                    PhoneNumbers = new List<IPhoneNumber> { new PhoneNumber("+1-555-555-5555") }
                },
                new Person { Id=101, FirstName="Wilma", LastName="Flintstone",
                    Emails = new List<IEmail> { new Email("Wilma@anotherCo.com") },
                    PhoneNumbers = new List<IPhoneNumber> { new PhoneNumber("+1-455-555-5555") }
                },
                new Person { Id=102, FirstName="Pebbles", LastName="Flintstone",
                    Emails = new List<IEmail> { new Email("pebles@anotherCo.com") },
                    PhoneNumbers = new List<IPhoneNumber> { new PhoneNumber("+1-455-555-5555") }
                },
                new Person { Id=103, FirstName="Barny", LastName="Rubble",
                    Emails = new List<IEmail> { new Email("brubble@anotherCo.com") },
                    PhoneNumbers = new List<IPhoneNumber> { new PhoneNumber("+1-355-555-5555") }
                }

            };

            _jobContacts = new List<JobSearchContact>
            {
                new JobSearchContact
                {
                    Id=11,
                    Person = _people.FirstOrDefault(p=>p.Id==100),
                    //Email = ,
                    //Phone = ,
                    Type =JobSearchContactType.Recruiter
                },
                new JobSearchContact
                {
                    Id=12,
                    Person = _people.FirstOrDefault(p=>p.Id==101),
                    //Email =new Email(""),
                    //Phone = new PhoneNumber("+1-455-555-5555"),
                    Type =JobSearchContactType.Acquaintance
                },
                new JobSearchContact
                {
                    Id=13,
                    Person = _people.FirstOrDefault(p=>p.Id==102),
                    //Email =new Email("Dude@anotherCo.com"),
                    //Phone = new PhoneNumber("+1-355-555-5555"),
                    Type =JobSearchContactType.EmployeeHumanResources
                },
                new JobSearchContact
                {
                    Id=14,
                    Person = _people.FirstOrDefault(p=>p.Id==103),
                    //Email =new Email("barny@anotherCo.com"),
                    //Phone = new PhoneNumber("+1-255-555-5555"),
                    Type =JobSearchContactType.EmployeeManager
                }
            };
            _activities = new List<JobSearchActivity>
            {
                new JobSearchActivity {
                    Id=1,
                    ActivityType =JobSearchActivityType.CvUpdate,
                    HappenedOn= timeStamp.AddDays(0),
                    Contact = _jobContacts.FirstOrDefault(p=>p.Id==11)
                },
                new JobSearchActivity {
                    Id =2,
                    ActivityType=JobSearchActivityType.JobBoardSearch,
                    HappenedOn=timeStamp.AddDays(-1),
                    Contact = _jobContacts.FirstOrDefault(p=>p.Id==12)
                },
                new JobSearchActivity {
                    Id =3,
                    ActivityType=JobSearchActivityType.JobBoardSearch,
                    HappenedOn=timeStamp.AddDays(-2),
                    Contact = _jobContacts.FirstOrDefault(p=>p.Id==13)
                },
                 new JobSearchActivity {
                    Id =4,
                    ActivityType=JobSearchActivityType.JobBoardSearch,
                    HappenedOn=timeStamp.AddDays(-3),
                    Contact = _jobContacts.FirstOrDefault(p=>p.Id==14)
                }
            };
        }

        #region//CRUD operations
        public void Add(JobSearchActivity newActivity)
        {
            throw new NotImplementedException();
        }

        public JobSearchActivity Get(int id)
        {
            return _activities.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<JobSearchActivity> GetAll()
        {
            return _activities;
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }
        #endregion//CRUD operations

    }
}
