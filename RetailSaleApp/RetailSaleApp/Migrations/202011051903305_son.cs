namespace RetailSaleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class son : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Product", "CategoryId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Product", "CategoryId");
            AddForeignKey("dbo.Product", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Product", new[] { "CategoryId" });
            DropColumn("dbo.Product", "CategoryId");
            DropTable("dbo.Categories");
        }
    }
}
