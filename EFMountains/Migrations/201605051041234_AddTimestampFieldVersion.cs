namespace EFMountains.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTimestampFieldVersion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Version");
        }
    }
}
