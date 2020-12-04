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
        private List<ProductModel> productsList;
        private List<OrderDetailModel> cartProducts;
        private string SelectedItem="";
        public frmShop()
        {
            InitializeComponent();
            productsPresenter = new ProductsPresenter(this);
            productsPresenter.Display();
            LoadListView();
            productsPresenter.getCartProduct();
        }
        ImageList imgListLarge;

        public List<OrderDetailModel> CartProducts
        {
            get {        
                return cartProducts;              
            }
            set
            {
                cartProducts = value;
            }
        }

        public List<ProductModel> Products
        {
            set
            {
                productsList = value;
            }
        }

        private void LoadImageList()
        {
            imgListLarge = new ImageList() { ImageSize = new Size(68,68)};
            for (int i = 0; i < productsList.Count; i++) {
                imgListLarge.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\" + productsList.ElementAt(i).ImgUrl));
            }
        }
        private void LoadListView()
        {
            LoadImageList();
            lsvShow.FullRowSelect = true;
            lsvShow.LargeImageList = imgListLarge;

            lsvShow.Columns.Add("Product Name");
            lsvShow.Columns.Add("Price");
            lsvShow.Columns.Add("Specs");

            for(int i = 0; i < productsList.Count; i++)
            {
                ListViewItem Product = new ListViewItem();
                Product.Text = productsList.ElementAt(i).ProductName;
                Product.ImageIndex = i;
                Product.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = productsList.ElementAt(i).UnitPrice.ToString() });
                Product.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = productsList.ElementAt(i).Specs.ToString() });
                lsvShow.Items.Add(Product);
            }

        }

        private void frmShop_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (SelectedItem != "")
            {
                for (int i = 0; i < productsList.Count; i++)
                {
                    if (SelectedItem.Equals(productsList.ElementAt(i).ProductName))
                    {
                        OrderDetailModel orderDetail = new OrderDetailModel
                        {
                            ProductName = productsList.ElementAt(i).ProductName,
                            UnitPrice = productsList.ElementAt(i).UnitPrice,
                            Specs = productsList.ElementAt(i).Specs,
                        };
                        cartProducts.Add(orderDetail);
                        productsPresenter.setCartProduct();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("You have to selected an item");
            }
        }

        private void lsvShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;
            SelectedItem = "";
            if (lsv.SelectedItems.Count > 0)
            {
                ListViewItem item = lsv.SelectedItems[0];
                SelectedItem = item.Text;
            }

        }
    }
}
