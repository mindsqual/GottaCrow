using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GottaCrowWebUI.Entities
{
    public enum JobSearchPersonType
    {
        None,
        Recruiter,
        HiringManager,
        EmployerHumanResources,
        Employee
    }
    public interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; }
        JobSearchPersonType PersonType { get; set; }

    }
    public class Person : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public JobSearchPersonType PersonType { get; set; }
    }
}
