namespace Spice_DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOrderDetailsandorderSummarytable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MenuItems", t => t.MenuId, cascadeDelete: false)
                .ForeignKey("dbo.OrderSummaries", t => t.OrderId, cascadeDelete: false)
                .Index(t => t.MenuId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.OrderSummaries",
                c => new
                    {
                        OId = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        TotalOrder = c.Int(nullable: false),
                        PickupDate = c.DateTime(nullable: false),
                        PickUpTime = c.DateTime(nullable: false),
                        PaymentStatus = c.String(nullable: false),
                        Comments = c.String(),
                        TransactionId = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.OId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.OrderSummaries");
            DropForeignKey("dbo.OrderDetails", "MenuId", "dbo.MenuItems");
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropIndex("dbo.OrderDetails", new[] { "MenuId" });
            DropTable("dbo.OrderSummaries");
            DropTable("dbo.OrderDetails");
        }
    }
}
