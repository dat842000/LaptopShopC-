using ActionService;
using AutoMapper;
using BusinessObjects;
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
        static List<ProductModel> listCartProducts;

        // danh sach san pham
        static List<ProductModel> listProduct;
        // thong tin nguoi dung
        static UserProfileModel user = new UserProfileModel();
        static Model()
        {
            listProduct = GetProductsData();

        }

        // lay du lieu
        public bool Login(string username, string password)
        {
            bool Result = false;
            var Account = service.GetAccount(username, password);
            if (Account != null)
            {
                Result = true;
                UserProfileModel info = new UserProfileModel
                {
                    AccountID = Account.AccountID,
                    UserImg = Account.UserImg,
                    FullName = Account.FullName,
                    Email = Account.Email,
                    Gender = Account.Gender,
                    Phone = Account.Phone,
                    Address = Account.Address,
                    Role = Account.Role,
                };
                user = info;
                GetOrderData();
            }
            return Result;
        }
        public static List<ProductModel> GetProductsData()
        {
            listProduct = new List<ProductModel>();
            var products = service.GetProducts();
            foreach (var product in products)
            {
                List<string> listSubImg = new List<string>();
                var subImgs = service.GetSubImgByProductID(product.ProductID);
                foreach( var sub in subImgs)
                {
                    string url = sub.UrlImg;
                    listSubImg.Add(url);
                }
                ProductModel p = new ProductModel
                {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    UnitPrice = product.UnitPrice,
                    Specs = product.Specs,
                    UnitInStock = product.Quantity,
                    ratingPoint = product.RatingPoint,
                    ImgUrl = product.ImgUrl,
                    SubImgs = listSubImg
                };
                listProduct.Add(p);
            }
            return listProduct;
        }
        public void GetOrderData()
        {
            listOrder = new List<OrderModel>();
            var order = service.GetOrdersByAccount(user.AccountID);
            foreach (var orderBussinessObject in order)
            {
                List<OrderDetailModel> orderDetailModels = new List<OrderDetailModel>();
                var listOrderDetail = service.GetOrderDetails(orderBussinessObject.OrderID);
                foreach (var ordDetail in listOrderDetail)
                {
                    OrderDetailModel orderDetail = new OrderDetailModel
                    {
                        ProductName = ordDetail.ProductName,
                        UnitPrice = ordDetail.UnitPrice,
                        ImgUrl = ordDetail.ImgUrl,
                        OrderDate = orderBussinessObject.OrderDate,
                        ShippedDate = orderBussinessObject.ShippedDate,
                        OrderStatus = ordDetail.OrderStatus,
                        Quantity = ordDetail.Quantity,
                        Specs = ordDetail.Specs
                    };
                    orderDetailModels.Add(orderDetail);
                }
                OrderModel ord = new OrderModel
                {
                    OrderID = orderBussinessObject.OrderID,
                    OrderDate = orderBussinessObject.OrderDate,
                    ShippedDate = orderBussinessObject.ShippedDate,
                    OrderStatus = orderBussinessObject.OrderStatus,
                    Quantity = orderBussinessObject.Quantity,
                    OrderDetails = orderDetailModels,
                    User = user
                };
                listOrder.Add(ord);
            }
        }
        public UserProfileModel GetUserProfile()
        {
            return user;
        }
        public List<ProductModel> GetProducts()
        {
            return listProduct;
        }


        // cap nhat du lieu 

        // thong tin gio hang
        public void SetCartProducts(List<ProductModel> cartProduct)
        {
            listCartProducts = cartProduct;
        }
        public List<ProductModel> GetCartProduct()
        {
            if (listCartProducts == null)
            { 
                listCartProducts = new List<ProductModel>();
                listProduct = GetProductsData();
                foreach(var product in listProduct)
                {
                    ProductModel p = new ProductModel
                    {
                        ProductID = product.ProductID,
                        ProductName = product.ProductName,
                        UnitPrice = product.UnitPrice,
                        Specs = product.Specs,
                        UnitInStock = 0,
                        ratingPoint = product.ratingPoint,
                        ImgUrl = product.ImgUrl,
                    };
                    listCartProducts.Add(p);
                }
            }
            
            return listCartProducts;
        }

        // tao hoa don
        public void setOrdering(List<OrderDetailModel> buyProducts)
        {
            // set total order
            int Total = 0;
            foreach(var orderdetail in buyProducts)
            {
                Total += orderdetail.Quantity;
            }
            Order order = new Order
            {
                AccountID = user.AccountID,
                OrderDate = DateTime.Now,
                ShippedDate = null,
                OrderStatus = "Processing",
                Quantity = Total,
            };
            service.InsertOrder(order);
            for (int i = 0; i < buyProducts.Count; i++)
            {
                OrderDetail detail = new OrderDetail
                {
                    OrderID = order.OrderID,
                    ProductID = buyProducts.ElementAt(i).ProductID,
                    UnitPrice = buyProducts.ElementAt(i).UnitPrice,
                    Quantity = buyProducts.ElementAt(i).Quantity,
                    ImgUrl = buyProducts.ElementAt(i).ImgUrl,
                    OrderStatus = buyProducts.ElementAt(i).OrderStatus,
                    Specs = buyProducts.ElementAt(i).Specs
                };
                service.InsertOrderDetail(detail);
            }
            GetOrderData();
        }
        public List<OrderDetailModel> getOrdering()
        {
            List<OrderDetailModel> orderingList = new List<OrderDetailModel>();
            var listSize = 0;
            if (listOrder != null)
            {
                listSize = listOrder.Count;
            }
            for (int i = 0; i < listSize; i++)
            {
                if (listOrder.ElementAt(i).OrderStatus.Equals("Processing"))
                {
                    for (int j = 0; j < listOrder.ElementAt(i).OrderDetails.Count; j++)
                    {
                        orderingList.Add(listOrder.ElementAt(i).OrderDetails.ElementAt(j));
                    }
                }
            }
            return orderingList;
        }

        // hoa don da thanh toan
        public List<OrderModel> getHistory()
        {
            List<OrderModel> historyList = new List<OrderModel>();
            var listSize = 0;

            if (listOrder != null)
            {
                listSize = listOrder.Count;
            }
            for (int i = 0; i < listSize; i++)
            { 
                historyList.Add(listOrder.ElementAt(i));

            }

            return historyList;
        }

        // dang ky tai khoan
        public Boolean Register(string Username, string Password, string Fullname, string Phone, string Email, string Address, Boolean Gender, string urlImg)
        {
            Boolean result = false;
            Account account = new Account
            {
                Username = Username,
                Pass = Password,
                FullName = Fullname,
                Phone = Phone,
                Email = Email,
                Address = Address,
                Gender = Gender,
                UserImg = urlImg,
            };
            Account oldAccount = service.CheckUserNameDuplicate(Username);
            if (oldAccount == null)
            {
                service.InsertAccount(account);
                return true;
            }
            return result;
        }
        // logout
        public void Logout()
        {
            user = new UserProfileModel();
            listOrder = new List<OrderModel>();
            listCartProducts = new List<ProductModel>();
        }

        // lay product by brand
        public List<ProductModel> getProductByBrand(int BrandID)
        {
            if (BrandID != 0)
            {
                List<Product> listProductGetByBrand = service.GetProductsByBrand(BrandID, "");
                listProduct = new List<ProductModel>();
                foreach (Product product in listProductGetByBrand)
                {
                    List<string> listSubImg = new List<string>();
                    var subImgs = service.GetSubImgByProductID(product.ProductID);
                    foreach (var sub in subImgs)
                    {
                        string url = sub.UrlImg;
                        listSubImg.Add(url);
                    }
                    ProductModel p = new ProductModel()
                    {
                        ProductID = product.ProductID,
                        ProductName = product.ProductName,
                        UnitPrice = product.UnitPrice,
                        Specs = product.Specs,
                        UnitInStock = product.Quantity,
                        ratingPoint = product.RatingPoint,
                        ImgUrl = product.ImgUrl,
                        SubImgs = listSubImg
                        
                    };
                    listProduct.Add(p);
                }
            }
            else
            {
                GetProductsData();
            }
            return listProduct;
        }
        // search Product
        public List<ProductModel> searchText(string searchText)
        {
            List<Product> searchProducts = service.SearchProducts(searchText, "");
            listProduct = new List<ProductModel>();
            foreach (Product product in searchProducts)
            {
                List<string> listSubImg = new List<string>();
                var subImgs = service.GetSubImgByProductID(product.ProductID);
                foreach (var sub in subImgs)
                {
                    string url = sub.UrlImg;
                    listSubImg.Add(url);
                }
                ProductModel p = new ProductModel()
                {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    UnitPrice = product.UnitPrice,
                    Specs = product.Specs,
                    UnitInStock = product.Quantity,
                    ratingPoint = product.RatingPoint,
                    ImgUrl = product.ImgUrl,
                    SubImgs = listSubImg
                };
                listProduct.Add(p);
            }
            return listProduct;
        }
    }
}
