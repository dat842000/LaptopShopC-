using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Product: BusinessObject
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Double UnitPrice { get; set; }
        public String Specs { get; set; }
        public  Double RatingPoint { get; set; }
        public int Quantity { get; set; }
        public string ImgUrl { get; set; }
        public Brand Brand { get; set; }
    }
}
