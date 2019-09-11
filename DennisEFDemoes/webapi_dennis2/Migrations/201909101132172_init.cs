namespace webapi_dennis2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SystemInfoes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ServerName = c.String(maxLength: 255),
                        ServerType = c.Int(nullable: false),
                        RunningAccount = c.String(),
                        RunningCommand = c.String(maxLength: 255),
                        Description = c.String(),
                        LastResponseTime = c.DateTime(nullable: false),
                        ResponseDelayThresholdInMinutes = c.Long(nullable: false),
                        Enable = c.Boolean(nullable: false),
                        CreatedDtm = c.DateTime(nullable: false),
                        ModifiedDtm = c.DateTime(nullable: false),
                        ModifyAuthor = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SystemInfoes");
        }
    }
}
