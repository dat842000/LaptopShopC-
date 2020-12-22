using ProjectCsharp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Views
{
    public interface IProductsView : IView
    {
        string searchProduct { get; }
        int BrandID { get; }
        List<ProductModel> CartProducts { get; set; }
        List<ProductModel> Products { set; }
    }
}
