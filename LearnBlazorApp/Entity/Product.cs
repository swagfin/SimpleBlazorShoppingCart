using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnBlazorApp.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string BarCode { get; set; }
        public int Quantity { get; set; } = 0;
        public double SellingPrice { get; set; } = 0;
        public string ImageFile { get; set; } = "default.png";
    }
}
