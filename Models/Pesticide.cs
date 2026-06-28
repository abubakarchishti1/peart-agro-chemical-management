using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peartagrochecmicalsmanagementsystem.Models
{
    internal class Pesticide
    {
        public int PesticideID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Company { get; set; }
        public string ActiveIngredient { get; set; }
        public string FormType { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockQty { get; set; }
        public int MinStockLevel { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string RegistrationNo { get; set; }

        public bool IsExpired => ExpiryDate < DateTime.Today;
        public bool IsLowStock => StockQty <= MinStockLevel;
        public string StockStatus => IsLowStock ? "Low Stock" : "In Stock";
    }
}
