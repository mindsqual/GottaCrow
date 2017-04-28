using JobSearch.Model;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace GottaCrow.DAL
{
    #region//DropCreateDatabaseAlways
    public class CustomInitializerDCA<T> : DropCreateDatabaseAlways<JobSearchDbContext>
    {
        public override void InitializeDatabase(JobSearchDbContext context)
        {
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction
                , string.Format("ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", context.Database.Connection.Database));

            base.InitializeDatabase(context);
        }


        protected override void Seed(JobSearchDbContext context)
        {
            /***** bp 4/26/17
             * I believe I want one company record in the database- always. 
             * We might need to add logic such as make sure this is always ID == 1
             * in otherwords, company with Id one is the person using the Application.
             */

            #region//Seeding for companies
            context.Companies.AddOrUpdate(
              c => c.Name,
              new Company { Name = "ThisCo" }
              );

            #endregion//Seeding for companies

            base.Seed(context);
        }
    }
    #endregion
}
