using ProjectCsharp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Presenters
{
    public class CartPresenter : Presenter<ICartView>
    {
        public CartPresenter(ICartView view) : base(view)
        {
        }
        public void Display()
        {
            View.CartProducts = Model.GetCartProduct();
        }
        public void setBuyProducts()
        {
            Model.setOrder(View.CartProducts);
        }
        public void setCartProduct()
        {
            Model.SetCartProducts(View.CartProducts);
        }
    }
}
