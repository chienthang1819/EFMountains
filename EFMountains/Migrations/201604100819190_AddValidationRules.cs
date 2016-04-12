namespace EFMountains.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValidationRules : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "Name", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Orders", "CreatedBy", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.OrderItems", "Name", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderItems", "Name", c => c.String());
            AlterColumn("dbo.Orders", "CreatedBy", c => c.String());
            AlterColumn("dbo.Orders", "Name", c => c.String());
        }
    }
}
