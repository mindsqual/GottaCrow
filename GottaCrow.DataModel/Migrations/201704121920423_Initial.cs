namespace GottaCrow.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JobSearchActivities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HappenedOn = c.DateTime(nullable: false),
                        ActivityType = c.Int(nullable: false),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JobSearchActivities", "Person_Id", "dbo.People");
            DropForeignKey("dbo.People", "CompanyId", "dbo.Companies");
            DropIndex("dbo.People", new[] { "CompanyId" });
            DropIndex("dbo.JobSearchActivities", new[] { "Person_Id" });
            DropTable("dbo.Companies");
            DropTable("dbo.People");
            DropTable("dbo.JobSearchActivities");
        }
    }
}
