namespace EFDemo_Many2ManyDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
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
                    })
                .PrimaryKey(t => t.SlotId);
            
            CreateTable(
                "dbo.SlotRankers",
                c => new
                    {
                        Slot_SlotId = c.Int(nullable: false),
                        Ranker_RankerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Slot_SlotId, t.Ranker_RankerId })
                .ForeignKey("dbo.Slots", t => t.Slot_SlotId, cascadeDelete: true)
                .ForeignKey("dbo.Rankers", t => t.Ranker_RankerId, cascadeDelete: true)
                .Index(t => t.Slot_SlotId)
                .Index(t => t.Ranker_RankerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SlotRankers", "Ranker_RankerId", "dbo.Rankers");
            DropForeignKey("dbo.SlotRankers", "Slot_SlotId", "dbo.Slots");
            DropIndex("dbo.SlotRankers", new[] { "Ranker_RankerId" });
            DropIndex("dbo.SlotRankers", new[] { "Slot_SlotId" });
            DropTable("dbo.SlotRankers");
            DropTable("dbo.Slots");
            DropTable("dbo.Rankers");
        }
    }
}
