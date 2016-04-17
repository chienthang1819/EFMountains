namespace EFMountains.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContactType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "DeliverTo_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "DeliverTo_Client", c => c.String());
            AddColumn("dbo.Orders", "DeliverTo_Phone", c => c.String());
            AddColumn("dbo.Orders", "DeliverTo_Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "DeliverTo_Address");
            DropColumn("dbo.Orders", "DeliverTo_Phone");
            DropColumn("dbo.Orders", "DeliverTo_Client");
            DropColumn("dbo.Orders", "DeliverTo_Id");
        }
    }
}
