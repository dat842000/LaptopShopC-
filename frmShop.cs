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
    public partial class frmShop : Form, IProductsView
    {
        private ProductsPresenter productsPresenter;
        private IList<ProductModel> products;
        public frmShop()
        {
            InitializeComponent();
            productsPresenter = new ProductsPresenter(this);
            productsPresenter.Display();
            LoadListView();

        }
        ImageList imgListLarge;


        public IList<ProductModel> Products
        {
            set
            {
                products = value;
            }
        }

        void LoadImageList()
        {
            imgListLarge = new ImageList() { ImageSize = new Size(68,68)};
            for (int i = 0; i < products.Count; i++) {
                imgListLarge.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\" + products.ElementAt(i).ImgUrl));
            }
        }
        void LoadListView()
        {
            LoadImageList();
            lsvShow.FullRowSelect = true;
            lsvShow.LargeImageList = imgListLarge;

            lsvShow.Columns.Add("Product Name");
            lsvShow.Columns.Add("Price");
            lsvShow.Columns.Add("Specs");

            for(int i = 0; i < products.Count; i++)
            {
                ListViewItem Product = new ListViewItem();
                Product.Text = products.ElementAt(i).ProductName;
                Product.ImageIndex = i;
                Product.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = products.ElementAt(i).UnitPrice.ToString() });
                Product.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = products.ElementAt(i).Specs.ToString() });
                lsvShow.Items.Add(Product);
            }

        }

        private void frmShop_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Icon_Click(object sender, EventArgs e)
        {
            lsvShow.View = View.LargeIcon;
        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            lsvShow.View = View.Details;
        }
    }
}
