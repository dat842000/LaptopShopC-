using ProjectCsharp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Presenters
{
    public class OrderPresenter : Presenter<IOrderView>
    {
        public OrderPresenter(IOrderView view) : base(view)
        {
        }
        public void Display()
        {
            View.OrderProducts = Model.getOrdering();
        }
    }
}
