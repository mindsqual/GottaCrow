using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GottaCrowWebUI.Entities
{
    public class JobSearchActivityDbContext : DbContext
    {
        public DbSet<JobSearchActivity> JobSearchActivities { get; set; }

        /// <summary>
        /// A job seeker has People in the database who are not neccesarily
        /// contacts that they have made in the coure of the search. 
        /// They might become JobSearch contacts at some point
        /// </summary>
        public DbSet<Person> People { get; set; }

        public DbSet<Contact> Contacts { get; set; }
    }
}
