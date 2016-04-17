namespace EFMountains.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveIdOnContact : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "DeliverTo_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "DeliverTo_Id", c => c.Int(nullable: false));
        }
    }
}
