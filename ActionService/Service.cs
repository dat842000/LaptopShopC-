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

        public List<Brand> GetBrands()
        {
            return brandDao.GetBrands();
        }

        public Brand GetBrandByProduct(int ProductID)
        {
            return brandDao.GetBrandByProduct(ProductID);
        }

        public Product GetProduct(int ProductID)
        {
            var product = productDao.GetProduct(ProductID);
            if (product.Brand == null)
                product.Brand = brandDao.GetBrandByProduct(ProductID);

            return product;
        }

        public List<Product> GetProductsByBrand(int BrandID, string sortExpression)
        {
            return productDao.GetProductsByBrand(BrandID, sortExpression);
        }

        public List<Product> SearchProducts(string productName, string sortExpression)
        {
            return productDao.SearchProducts(productName, sortExpression);
        }

        public List<Account> GetAccounts(string sortExpression)
        {
            var Accounts = accountDao.GetAccounts(sortExpression);
            Accounts.RemoveAll(m => m.AccountID == 1);  // exclude admin (for demo purposes)
            return Accounts;
        }

        public Account GetAccountByOrder(int OrderID)
        {
            return accountDao.GetAccountByOrder(OrderID);
        }

        public List<Account> GetAccountsWithOrderStatistics(string sortExpression)
        {
            return accountDao.GetAccountsWithOrderStatistics(sortExpression);
        }

        public void InsertAccount(Account account)
        {
            accountDao.InsertAccount(account);
        }

        public void UpdateAccount(Account account)
        {
            accountDao.UpdateAccount(account);
        }

        public void DeleteAccount(Account account)
        {
            accountDao.DeleteAccount(account);
        }

        public Order GetOrder(int OrderID)
        {
            return orderDao.GetOrder(OrderID);
        }

        public List<Order> GetOrdersByAccount(int AccountID)
        {
            return orderDao.GetOrdersByAccount(AccountID);
        }

        public List<OrderDetail> GetOrderDetails(int OrderID)
        {
            return orderDetailDao.GetOrderDetails(OrderID);
        }

        //public bool Login(string email, string password)
        //{
        //    // websecurity does not accept null or empty

        //    if (string.IsNullOrEmpty(email)) return false;
        //    if (string.IsNullOrEmpty(password)) return false;

        //    return WebSecurity.Login(email, password);
        //}

        //public void Logout()
        //{
        //    WebSecurity.Logout();
        //}
    }
}
