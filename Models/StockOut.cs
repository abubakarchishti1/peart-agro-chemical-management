using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peartagrochecmicalsmanagementsystem.Models
{
    internal class StockOut
    {
        public int StockOutID { get; set; }
        public int PesticideID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalAmount => Quantity * UnitPrice;
        public string CustomerName { get; set; }
        public DateTime StockOutDate { get; set; }
        public string Remarks { get; set; }
    }
}
