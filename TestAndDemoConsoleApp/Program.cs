using GottaCrow.DAL;
using System.Data.Entity;
using System;
using JobSearch.Model;

namespace TestAndDemoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database.SetInitializer(new NullDatabaseInitializer<JobSearchDbContext>());
            InsertPerson();
            //InsertActivity();
            Console.ReadLine();
        }

        private static void InsertPerson()
        {
            var firstPerson = new Person()
            {
                FirstName = "Ikabod",
                LastName = "Crain",
                DateCreated = DateTime.Now
            };
            using (var context = new JobSearchDbContext())
            {
                context.Database.Log = Console.WriteLine;
                context.People.Add(firstPerson);
            }
        }

        //private static void InsertActivity()
        //{
        //    var jsa = new JobSearch.Model.JobSearchActivity
        //    {
        //        Description = "Testing Insertion of A job search activity record",
        //        DateCreated = DateTime.Now,
        //        ActivityType = JobSearch.Model.ActivityType.ApplyForPosition,
        //        //to-do: populate people list...
        //    };
        //}
    }
}
