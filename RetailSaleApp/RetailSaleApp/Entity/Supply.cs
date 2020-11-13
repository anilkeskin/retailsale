using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailSaleApp.Entity
{
    [Table("Supplier")]
    class Supply:BaseEntity
    {
        public Supply()
        {
            Id = Guid.NewGuid();
        }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierPhone { get; set; }

    }
}
