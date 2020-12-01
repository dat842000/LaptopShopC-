using ProjectCsharp.Models.Models;
using ProjectCsharp.Presenters;
using ProjectCsharp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCsharp
{
    public partial class frmCart : Form, ICartView
    {
        private CartPresenter cartPresenter;
        private IList<ProductModel> cartProducts;
        public frmCart()
        {
            InitializeComponent();
            cartPresenter = new CartPresenter(this);
            cartPresenter.Display();
        }
        public List<ProductModel> CartProducts
        {
            set
            {
                cartProducts = value;
            }
        }
        private void LoadListView()
        {
            
        }
    }
}
