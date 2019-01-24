namespace EFDemo_Many2ManyDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        ModelId = c.Int(nullable: false),
                        Id = c.Long(nullable: false, identity: true),
                        ModelName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ModelId);
            
            CreateTable(
                "dbo.Rankers",
                c => new
                    {
                        RankerId = c.Int(nullable: false),
                        Id = c.Long(nullable: false, identity: true),
                        RankerName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RankerId);
            
            CreateTable(
                "dbo.Slots",
                c => new
                    {
                        SlotId = c.Int(nullable: false),
                        Id = c.Long(nullable: false, identity: true),
                        SlotName = c.String(),
                        RankerUsage = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SlotId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Slots");
            DropTable("dbo.Rankers");
            DropTable("dbo.Models");
        }
    }
}
