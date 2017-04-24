namespace GottaCrow.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTxtFieldsJsActivty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobSearchActivities", "Description", c => c.String());
            AddColumn("dbo.JobSearchActivities", "Notes", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.JobSearchActivities", "Notes");
            DropColumn("dbo.JobSearchActivities", "Description");
        }
    }
}
