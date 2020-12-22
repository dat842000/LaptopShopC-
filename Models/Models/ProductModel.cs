using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Models.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Double UnitPrice { get; set; }
        public string Specs { get; set; }
        public Double ratingPoint { get; set; }
        public int UnitInStock { get; set; }
        public string ImgUrl { get; set; }
        public List<string> SubImgs { get; set; }
    }
}
