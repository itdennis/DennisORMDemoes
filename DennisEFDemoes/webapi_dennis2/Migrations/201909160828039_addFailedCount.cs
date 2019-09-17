namespace webapi_dennis2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFailedCount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SystemInfoes", "FailedCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SystemInfoes", "FailedCount");
        }
    }
}
