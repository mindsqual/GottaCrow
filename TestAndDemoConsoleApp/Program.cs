using GottaCrow.DAL;
using System.Data.Entity;
using System;
using JobSearch.Model;
using System.Data.SqlClient;

namespace TestAndDemoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database.SetInitializer(new NullDatabaseInitializer<JobSearchDbContext>());
            Database.SetInitializer(new CustomInitializerDCA<JobSearchDbContext>());
            InitDataBase();
            InsertFirstPerson();  // the seed method in DAL inserts the first company. must be there
            InsertSecondPerson();
            InsertActivity();
            //Console.WriteLine("Do you want to re-set the database to empty?");
            //Console.Read();
            
            Console.ReadLine();
        }
        
        private static void InsertFirstPerson()
        {
            var firstPerson = new Person()
            {
                FirstName = "Ikabod",
                LastName = "Crain",
                CompanyId=1
                //DateCreated = DateTime.Now //set in SaveChanges override....
            };
            using (var context = new JobSearchDbContext())
            {
                context.Database.Log = Console.WriteLine;
                context.People.Add(firstPerson);
                context.SaveChanges();
            }
        }

        private static void InsertSecondPerson()
        {
            var secondPerson = new Person()
            {
                FirstName = "Rip",
                LastName = "Vanwinkle",
                CompanyId = 1
                //DateCreated = DateTime.Now //set in SaveChanges override....
            };
            using (var context = new JobSearchDbContext())
            {
                context.Database.Log = Console.WriteLine;
                context.People.Add(secondPerson);
                context.SaveChanges();
            }
        }

        private static void InsertActivity()
        {
            var jsa = new JobSearch.Model.JobSearchActivity
            {
                Description = "Testing Insertion and database cleanup",
                Date = DateTime.Now,
                ActivityType = JobSearch.Model.ActivityType.ApplyForPosition,
                //to-do: populate people list...
            };

            using (var context = new JobSearchDbContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Activities.Add(jsa);
                context.SaveChanges();
            }
        }

        //clear out data and set the identy seed to 1
        private static void InitDataBase()
        {
            Console.WriteLine("Initializing database. THis will drop current connections.");
            using (var context = new JobSearchDbContext())
            {
                //context.Database.Log = Console.WriteLine;
                //SqlConnection.ClearAllPools();
                context.Database.Initialize(true);

            }
        }
    }
}
