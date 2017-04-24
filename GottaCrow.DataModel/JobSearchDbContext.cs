using JobSearch.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace GottaCrow.DAL
{
    public class JobSearchDbContext : DbContext
    {
        DbSet<JobSearchActivity> Activities { get; set; }

        DbSet<Person> People { get; set; }

        DbSet<Company> Companies { get; set; }

        #region//Context Configuration-Persistence
        /*EF will never know about IsDirty-- it is only meant to be used in the app. Not persisted...*/
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Types().
                Configure(c => c.Ignore("IsDirty"));
            base.OnModelCreating(modelBuilder);
        }
        #endregion//Context Configuration-Persistence

        #region//Save Changes override
        public override int SaveChanges()
        {
            //find all entities that are implementing the IModificationHistory interface...
            foreach (var history in this.ChangeTracker.Entries()
              .Where(e => e.Entity is IModificationHistory && (e.State == EntityState.Added ||
                      e.State == EntityState.Modified))
               .Select(e => e.Entity as IModificationHistory)
              )
            {
                history.DateModified = DateTime.Now;
                if (history.DateCreated == DateTime.MinValue)
                {
                    history.DateCreated = DateTime.Now;
                }
            }
            int result = base.SaveChanges();
            // set isDirty back to false (clear)...
            foreach (var history in this.ChangeTracker.Entries()
                                          .Where(e => e.Entity is IModificationHistory)
                                          .Select(e => e.Entity as IModificationHistory)
              )
            {
                history.IsDirty = false;
            }
            return result;
        }
        #endregion//Save Changes override
    }
}

