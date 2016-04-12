namespace EFMountains.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        CreatedBy = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Price = c.Single(nullable: false),
                        Amount = c.Int(nullable: false),
                        Order_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.Order_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "Order_Id", "dbo.Orders");
            DropIndex("dbo.OrderItems", new[] { "Order_Id" });
            DropTable("dbo.OrderItems");
            DropTable("dbo.Orders");
        }
    }
}
