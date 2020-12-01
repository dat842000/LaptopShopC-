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
        private List<ProductModel> CartProducts = new List<ProductModel>();
        private string SelectedItem="";
        public frmShop()
        {
            InitializeComponent();
            productsPresenter = new ProductsPresenter(this);
            productsPresenter.Display();
            LoadListView();

        }
        ImageList imgListLarge;


        public List<ProductModel> Products
        {
            get
            {
                return CartProducts;
            }
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

        private void btn_Icon_Click(object sender, EventArgs e)
        {
            lsvShow.View = View.LargeIcon;
        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            lsvShow.View = View.Details;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(SelectedItem != "")
            {
                for (int i = 0; i < productsList.Count; i++)
                {
                    if (SelectedItem.Equals(productsList.ElementAt(i).ProductName))
                    {
                        CartProducts.Add(productsList.ElementAt(i));
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
