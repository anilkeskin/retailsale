using RetailSaleApp.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailSaleApp
{
    class MyContext :DbContext
    {
        public MyContext() : base("name=MyCon")
        {

        }
        public DbSet<Product> ProductTables { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Supply> Supplies { get; set; }
    }
}
