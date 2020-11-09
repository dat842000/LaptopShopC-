using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public interface IDaoFactory
    {
        IAccountDao AccountDao { get; }
        IOrderDao OrderDao { get; }
        IOrderDetailDao OrderDetailDao { get; }
        IProductDao ProductDao { get; }
        IBrandDao BrandDao { get; }
    }
}
