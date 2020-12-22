using BusinessObjects;
using DataObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionService
{
    public class Service : IService
    {
        static readonly string provider = ConfigurationManager.AppSettings.Get("DataProvider");
        static readonly IDaoFactory factory = DaoFactories.GetFactory(provider);

        static readonly IBrandDao brandDao = factory.BrandDao;
        static readonly IProductDao productDao = factory.ProductDao;
        static readonly IAccountDao accountDao = factory.AccountDao;
        static readonly IOrderDao orderDao = factory.OrderDao;
        static readonly IOrderDetailDao orderDetailDao = factory.OrderDetailDao;
        static readonly ISubImgDao subImgDao = factory.SubImgDao;

        //public List<Brand> GetBrands()
        //{
        //    return brandDao.GetBrands();
        //}

        public List<Product> GetProducts()
        {
            return productDao.GetProducts();
        }

        public List<Product> GetProductsByBrand(int BrandID, string sortExpression)
        {
            return productDao.GetProductsByBrand(BrandID, sortExpression);
        }

        public List<Product> SearchProducts(string productName, string sortExpression)
        {
            return productDao.SearchProducts(productName, sortExpression);
        }

        public Account GetAccount(string Username, string Password)
        {
            var Account = accountDao.GetAccount(Username,Password);
            return Account;
        }


        public void InsertAccount(Account account)
        {
            accountDao.InsertAccount(account);
        }
        public Account CheckUserNameDuplicate(string Username)
        {
            return accountDao.CheckUserNameDuplicate(Username);
        }

        //public void UpdateAccount(Account account)
        //{
        //    accountDao.UpdateAccount(account);
        //}


        public List<Order> GetOrdersByAccount(int AccountID)
        {
            return orderDao.GetOrdersByAccount(AccountID);
        }

        public List<OrderDetail> GetOrderDetails(int OrderID)
        {
            return orderDetailDao.GetOrderDetails(OrderID);
        }

        public void InsertOrder(Order order)
        {
            orderDao.InsertOrder(order);
        }

        public void InsertOrderDetail(OrderDetail orderDetail)
        {
            orderDetailDao.InsertOrderDetail(orderDetail);
        }
        public List<SubImg> GetSubImgByProductID(int ProductID)
        {
            return subImgDao.GetSubImgByProductID(ProductID);
        }

        //public bool Login(string email, string password)
        //{
        //    // websecurity does not accept null or empty

        //    if (string.IsNullOrEmpty(email)) return false;
        //    if (string.IsNullOrEmpty(password)) return false;

        //return WebSecurity.Login(email, password);
        //}

        //public void Logout()
        //{
        //    WebSecurity.Logout();
        //}
    }
}
