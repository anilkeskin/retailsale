namespace RetailSaleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sonverimiz : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "UnitPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "UnitPrice");
        }
    }
}
