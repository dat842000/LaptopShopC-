using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Views
{
    public interface IProductView : IView
    {
        int ProductID { get; set; }
        string ProductName { get; set; }
        float UnitPrice { get; set; }
        int Specs { get; set; }
        string ImgUrl { get; set; }
    }
}
