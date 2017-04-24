using GottaCrow.DAL;
using System.Data.Entity;
using System;

namespace TestAndDemoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new NullDatabaseInitializer<JobSearchDbContext>());
            InsertActivity();
        }

        private static void InsertActivity()
        {
            throw new NotImplementedException();
        }
    }
}
