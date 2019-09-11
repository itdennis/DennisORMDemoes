namespace DennisEFDemoes_ConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsysteminfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PictureCategory",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ParentCategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.CategoryId)
                .ForeignKey("dbo.PictureCategory", t => t.ParentCategoryId)
                .Index(t => t.ParentCategoryId);
            
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
            DropForeignKey("dbo.PictureCategory", "ParentCategoryId", "dbo.PictureCategory");
            DropIndex("dbo.PictureCategory", new[] { "ParentCategoryId" });
            DropTable("dbo.SystemInfoes");
            DropTable("dbo.PictureCategory");
        }
    }
}
