using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.AdoNet
{
    public class DaoFactory : IDaoFactory
    {
        public IAccountDao AccountDao { get { return new AccountDao(); } }
        public IOrderDao OrderDao { get { return new OrderDao(); } }
        public IOrderDetailDao OrderDetailDao { get { return new OrderDetailDao(); } }
        public IProductDao ProductDao { get { return new ProductDao(); } }
        public IBrandDao BrandDao { get { return new BrandDao(); } }
        public ISubImgDao SubImgDao { get { return new SubImgDao(); } }
    }
}
