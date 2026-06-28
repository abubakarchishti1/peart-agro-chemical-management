using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peartagrochecmicalsmanagementsystem.Models
{
    internal class StockIn
    {
        public int StockInID { get; set; }
        public int PesticideID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public decimal TotalCost => Quantity * UnitCost;
        public DateTime StockInDate { get; set; }
        public string Remarks { get; set; }
    }
}
