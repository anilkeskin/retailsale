using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailSaleApp.Entity
{
    [Table("Product")]
    class Product :BaseEntity
    {
        public Product()
        {
            Id = Guid.NewGuid();
        }
        public string ProductName { get; set; }
        public string ProductBarcode { get; set; }
        public double UnitPrice { get; set; }
        public double SellPrice { get; set; }
        
        public Guid CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public Guid SupplierId { get; set; }

        [ForeignKey("SupplierId")]
        public virtual Supply Supply { get; set; }

        public virtual List<Stock> Stocks { get; set; } = new List<Stock>();



    }
}
