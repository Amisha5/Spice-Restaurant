namespace Spice_DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MenuIdaddedintableOrderSummary : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderSummaries", "MenuId", c => c.Int(nullable: false));
            CreateIndex("dbo.OrderSummaries", "MenuId");
            AddForeignKey("dbo.OrderSummaries", "MenuId", "dbo.MenuItems", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderSummaries", "MenuId", "dbo.MenuItems");
            DropIndex("dbo.OrderSummaries", new[] { "MenuId" });
            DropColumn("dbo.OrderSummaries", "MenuId");
        }
    }
}
