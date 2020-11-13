using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RetailSaleApp.Enums.AppEnums;

namespace RetailSaleApp.Entity
{
    [Table("Stock")]
    class Stock:BaseEntity
    {
        public Stock()
        {
            Id = Guid.NewGuid();
        }
        public Colors Color { get; set; }
        public int Quantity { get; set; }

        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
