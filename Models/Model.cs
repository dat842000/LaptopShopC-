using ActionService;
using ProjectCsharp.Models;
using ProjectCsharp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Models
{
    public class Model : IModel
    {
        static Service service = new Service();
        static Model()
        {

        }
        public bool Login(string username, string password)
        {
            bool Result = false;
            if (username != null && password != null)
            {
                Result = (username == "admin" && password == "secret");
            }
            return Result;
        }
        public List<ProductModel> GetProducts()
        {
            List<ProductModel> listProduct = new List<ProductModel>();
            ProductModel p1 = new ProductModel
            {
                ProductID = 1,
                ProductName = "Acer Nitro 5",
                UnitPrice = 599.00f,
                Specs = 2018,
                ImgUrl = "Acer Nitro 5.png"
            };
            ProductModel p2 = new ProductModel
            {
                ProductID = 2,
                ProductName = "Hp Zbook 150 G3",
                UnitPrice = 1499.50f,
                Specs = 2016,
                ImgUrl = "Hp Zbook 150 G3.png"
            };
            ProductModel p3 = new ProductModel
            {
                ProductID = 3,
                ProductName = "Msi GL63",
                UnitPrice = 999.99f,
                Specs = 2018,
                ImgUrl = "Msi GL63.png"
            };
            listProduct.Add(p1);
            listProduct.Add(p2);
            listProduct.Add(p3);
            return listProduct;
        }
    }
}
