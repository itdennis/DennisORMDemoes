namespace DennisEFDemoes_ConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRowVersion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SystemInfoes", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SystemInfoes", "RowVersion");
        }
    }
}
