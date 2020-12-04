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
        // danh sach san pham order
        static List<OrderModel> listOrder;

        // danh sach san pham trong gio hang
        static List<OrderDetailModel> listCartProducts;

        // danh sach san pham
        static List<ProductModel> listProduct ;
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
        public UserProfileModel UserProfile()
        {
            UserProfileModel info = new UserProfileModel
            {
                AccountID = 1,
                UserImg = "DatNguyen.png",
                FullName = "Nguyen Phuc Dat",
                Email = "dnn8420@gmail.com",
                Gender = true,
                Phone = "0523093320",
                Address = "TP.BienHoa T.DongNai",
                Role = "Customer",
            };
            return info;
        }
        public List<ProductModel> GetProducts()
        {
            listProduct = new List<ProductModel>();
            ProductModel p1 = new ProductModel
            {
                ProductID = 1,
                ProductName = "Acer Nitro 5",
                UnitPrice = 599.00f,
                Specs = 2018,
                UnitInStock = 5,
                ImgUrl = "Acer Nitro 5.png"

            };
            ProductModel p2 = new ProductModel
            {
                ProductID = 2,
                ProductName = "Hp Zbook 150 G3",
                UnitPrice = 1499.50f,
                Specs = 2016,
                UnitInStock = 5,
                ImgUrl = "Hp Zbook 150 G3.png"
            };
            ProductModel p3 = new ProductModel
            {
                ProductID = 3,
                ProductName = "Msi GL63",
                UnitPrice = 999.99f,
                Specs = 2018,
                UnitInStock = 5,
                ImgUrl = "Msi GL63.png"
            };
            ProductModel p4 = new ProductModel
            {
                ProductID = 4,
                ProductName = "LenovoIdeaPad",
                UnitPrice = 879.00f,
                Specs = 2018,
                UnitInStock = 5,
                ImgUrl = "LenovoIdeaPad.png"
            };
            ProductModel p5 = new ProductModel
            {
                ProductID = 5,
                ProductName = "Acer Swift 5",
                UnitPrice = 1098.00f,
                Specs = 2019,
                UnitInStock = 5,
                ImgUrl = "Acer Swift 5.png"
            };
            ProductModel p6 = new ProductModel
            {
                ProductID = 5,
                ProductName = "Asus TUF FX505DT",
                UnitPrice = 850.00f,
                Specs = 2019,
                //UnitInStock = 5,
                ImgUrl = "Asus TUF FX505DT.png"
            };
            listProduct.Add(p1);
            listProduct.Add(p2);
            listProduct.Add(p3);
            listProduct.Add(p4);
            listProduct.Add(p5);
            listProduct.Add(p6);
            return listProduct;
        }
        public void SetCartProducts(List<OrderDetailModel> cartProduct)
        {
            listCartProducts = cartProduct;
        }
        public List<OrderDetailModel> GetCartProduct()
        {
            if (listCartProducts == null) listCartProducts = new List<OrderDetailModel>();
            return listCartProducts;
        }

        public void setOrder(List<OrderDetailModel> buyProducts)
        {
            listOrder = getHistory();
            var orderID =0;
            if(listOrder == null)
            {
                listOrder = new List<OrderModel>();
                orderID = 1;
            }
            else
            {
                orderID = listOrder.Count + 1;
            }
            OrderModel orderModel = new OrderModel
            {
                OrderID = orderID,
                OrderDetails = buyProducts,
                OrderDate = DateTime.Now,
                ShippedDate = null,
                OrderStatus = "Pending",
                User = UserProfile(),
                Quantity = buyProducts.Count,
            };
            listOrder.Add(orderModel);
        }
        public List<OrderDetailModel> getOrder()
        {
            List<OrderDetailModel> orderList = new List<OrderDetailModel>();
            var listSize = 0;
            listOrder = getHistory();
            if (listOrder != null)
            {
                listSize = listOrder.Count;
            }
            for (int i = 0; i < listSize; i++)
            {
                if (listOrder.ElementAt(i).OrderStatus.Equals("Pending"))
                {
                    for (int j = 0; j < listOrder.ElementAt(i).OrderDetails.Count; j++) {
                        orderList.Add(listOrder.ElementAt(i).OrderDetails.ElementAt(j));
                    }
                }
            }
            return orderList;
        }
        public List<OrderModel> getHistory()
        {
            // 
            if (listOrder == null)
            {
                GetProducts();
                listOrder = new List<OrderModel>();
                List<OrderDetailModel> listOrderDetails = new List<OrderDetailModel>();
                OrderDetailModel orderDetail1 = new OrderDetailModel
                {
                    ProductName = listProduct.ElementAt(1).ProductName,
                    Specs = listProduct.ElementAt(1).Specs,
                    UnitPrice = listProduct.ElementAt(1).UnitPrice,
                    OrderDate = DateTime.Now.AddDays(-2),
                };
                listOrderDetails.Add(orderDetail1);
                OrderDetailModel orderDetail2 = new OrderDetailModel
                {
                    ProductName = listProduct.ElementAt(1).ProductName,
                    Specs = listProduct.ElementAt(1).Specs,
                    UnitPrice = listProduct.ElementAt(1).UnitPrice,
                    OrderDate = DateTime.Now.AddDays(-2),
                };
                listOrderDetails.Add(orderDetail2);
                OrderModel orderModel1 = new OrderModel
                {
                    OrderID = 1,
                    OrderDetails = listOrderDetails,
                    OrderDate = DateTime.Now.AddDays(-2),
                    OrderStatus = "Pending",
                    User = UserProfile(),
                    Quantity = listOrderDetails.Count,
                };
                listOrder.Add(orderModel1);
            }
            return listOrder;
        }
    }
}
