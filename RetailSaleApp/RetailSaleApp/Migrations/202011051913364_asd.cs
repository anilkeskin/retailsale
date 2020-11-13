namespace RetailSaleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stock",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Color = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        ProductId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stock", "ProductId", "dbo.Product");
            DropIndex("dbo.Stock", new[] { "ProductId" });
            DropTable("dbo.Stock");
        }
    }
}
