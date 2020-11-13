using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailSaleApp.Entity
{
    [Table("Category")]
    class Category:BaseEntity
    {
        public Category()
        {
            Id = Guid.NewGuid();
        }
        public string CategoryName { get; set; }
    }
}
