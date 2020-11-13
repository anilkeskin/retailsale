namespace RetailSaleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sonveri : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Categories", newName: "Category");
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SupplierName = c.String(),
                        SupplierAddress = c.String(),
                        SupplierPhone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Product", "ProductBarcode", c => c.String());
            AddColumn("dbo.Product", "SupplierId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Product", "SupplierId");
            AddForeignKey("dbo.Product", "SupplierId", "dbo.Supplier", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "SupplierId", "dbo.Supplier");
            DropIndex("dbo.Product", new[] { "SupplierId" });
            DropColumn("dbo.Product", "SupplierId");
            DropColumn("dbo.Product", "ProductBarcode");
            DropTable("dbo.Supplier");
            RenameTable(name: "dbo.Category", newName: "Categories");
        }
    }
}
