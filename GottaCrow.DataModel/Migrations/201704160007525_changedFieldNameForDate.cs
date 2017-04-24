namespace GottaCrow.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedFieldNameForDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobSearchActivities", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.JobSearchActivities", "HappenedOn");
        }
        
        public override void Down()
        {
            AddColumn("dbo.JobSearchActivities", "HappenedOn", c => c.DateTime(nullable: false));
            DropColumn("dbo.JobSearchActivities", "Date");
        }
    }
}
