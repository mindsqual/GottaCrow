namespace GottaCrow.DataModel.Migrations
{
    using JobSearch.Model;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<GottaCrow.DAL.JobSearchDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GottaCrow.DAL.JobSearchDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //

            #region//Seeding for companies-moved to custom initializer
            //context.Companies.AddOrUpdate(
            //  c => c.Name,
            //  new Company { Name = "ThisCo" }
            /* 
             * moved this to custom initializer...
             * I believe I want one company record in the database- always. 
             * We might need to add logic such as make sure this is always ID == 1
             * in otherwords, company with Id one is the person using the Application.
             */

              //);

              #endregion//Seeding for companies

        }
    }
}
