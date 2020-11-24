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
        public float UnitPrice { get; set; }
        public int Specs { get; set; }
        public string ImgUrl { get; set; }
    }
}
