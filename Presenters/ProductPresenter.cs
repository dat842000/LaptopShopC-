using ProjectCsharp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Presenters
{
    public class ProductPresenter : Presenter<IProductView>
    {
        public ProductPresenter(IProductView view) : base(view)
        {
        }

    }
}
