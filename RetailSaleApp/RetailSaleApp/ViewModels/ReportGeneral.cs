using RetailSaleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailSaleApp.ViewModels
{
    class ReportGeneral
    {
        public string ProductName { get; internal set; }
        public string ProductCategory { get; internal set; }
        public string ProductSupplier { get; internal set; }
        public AppEnums.Colors Color { get; internal set; }
        public int Quantity { get; internal set; }

        public double UnitPrice { get; internal set; }
        public double SellPrice { get; internal set; }

    }
}
