namespace GottaCrow.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CoNamePropChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Name", c => c.String());
            DropColumn("dbo.Companies", "CompanyName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Companies", "CompanyName", c => c.String());
            DropColumn("dbo.Companies", "Name");
        }
    }
}
