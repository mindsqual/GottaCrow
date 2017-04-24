namespace GottaCrow.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addModHistPropsIgnoreBool : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobSearchActivities", "DateModified", c => c.DateTime(nullable: false));
            AddColumn("dbo.JobSearchActivities", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.People", "DateModified", c => c.DateTime(nullable: false));
            AddColumn("dbo.People", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Companies", "DateModified", c => c.DateTime(nullable: false));
            AddColumn("dbo.Companies", "DateCreated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "DateCreated");
            DropColumn("dbo.Companies", "DateModified");
            DropColumn("dbo.People", "DateCreated");
            DropColumn("dbo.People", "DateModified");
            DropColumn("dbo.JobSearchActivities", "DateCreated");
            DropColumn("dbo.JobSearchActivities", "DateModified");
        }
    }
}
