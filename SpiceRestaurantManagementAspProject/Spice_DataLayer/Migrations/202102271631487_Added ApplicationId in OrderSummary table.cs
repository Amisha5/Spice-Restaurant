namespace Spice_DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedApplicationIdinOrderSummarytable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderSummaries", "ApplicationUserId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderSummaries", "ApplicationUserId");
        }
    }
}
