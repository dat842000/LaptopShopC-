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
using Guna.UI.WinForms;

namespace ProjectCsharp
{
    public partial class frmShop : Form, IProductsView
    {
        private ProductsPresenter productsPresenter;
        private List<ProductModel> productsList;
        private List<ProductModel> cartProducts;
        private int brandID = 0;
        private string searchText = "";
        private string SelectedItem="";
        private Boolean Login;
        public frmShop(Boolean LoginStatus)
        {
            InitializeComponent();
            productsPresenter = new ProductsPresenter(this);
            productsPresenter.Display();
            productsPresenter.getCartProduct();
            TextChanged();
            Login = LoginStatus;
        }

        public List<ProductModel> CartProducts
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

        public int BrandID
        {
            get
            {
                return brandID;
            }
        }

        public string searchProduct
        {
            get
            {
                return searchText;
            }
        }
        private void ClearImgForm(int size)
        {
            gunaPictureBox1.Image = null;
            gunaPictureBox2.Image = null;
            gunaPictureBox3.Image = null;
            gunaPictureBox4.Image = null;
            gunaPictureBox1.Enabled = false;
            gunaPictureBox2.Enabled = false;
            gunaPictureBox3.Enabled = false;
            gunaPictureBox4.Enabled = false;
            for (int i = 0; i < size; i++)
            {
                if (i == 0) gunaPictureBox1.Enabled = true;
                if (i == 1) gunaPictureBox2.Enabled = true;
                if (i == 2) gunaPictureBox3.Enabled = true;
                if (i == 3) gunaPictureBox4.Enabled = true;
            }
        }
        private void loadPanel()
        {
            flowPanel.Controls.Clear();
            for (int i = 0; i < productsList.Count; i++)
            {
                var UsersGrid = new Laptop
                {
                    name = productsList.ElementAt(i).ProductName,
                    urlImg = productsList.ElementAt(i).ImgUrl,
                    unitprice = productsList.ElementAt(i).UnitPrice.ToString(),
                    rating = productsList.ElementAt(i).ratingPoint,
                    SubImgs = productsList.ElementAt(i).SubImgs,
                };
                UsersGrid.MyForm = this;
                UsersGrid.UserControlButtonClicked += new
                    EventHandler(MyUserControl_UserControlButtonClicked);
                flowPanel.Controls.Add(UsersGrid);
            }
            if (productsList.Count != 0)
            {
                guna2PictureBox1.Image = new Bitmap(Application.StartupPath + "\\Images\\" + productsList.ElementAt(0).ImgUrl);
                List<string> listSubImg = productsList.ElementAt(0).SubImgs;
                string subFolderName = productsList.ElementAt(0).ProductName;
                if (listSubImg != null)
                {
                    ClearImgForm(listSubImg.Count - 1);
                    for (int i = 0; i < listSubImg.Count; i++)
                    {
                        if (i == 0)
                        {
                            gunaPictureBox1.Image = new Bitmap(Application.StartupPath + "\\Images\\" + subFolderName + "\\" + listSubImg.ElementAt(i));
                        }
                        if (i == 1)
                        {
                            gunaPictureBox2.Image = new Bitmap(Application.StartupPath + "\\Images\\" + subFolderName + "\\" + listSubImg.ElementAt(i));
                        }
                        if (i == 2)
                        {
                            gunaPictureBox3.Image = new Bitmap(Application.StartupPath + "\\Images\\" + subFolderName + "\\" + listSubImg.ElementAt(i));
                        }
                        if (i == 3)
                        {
                            gunaPictureBox4.Image = new Bitmap(Application.StartupPath + "\\Images\\" + subFolderName + "\\" + listSubImg.ElementAt(i));
                        }
                    }
                }
                lbl_Laptopname.Text = productsList.ElementAt(0).ProductName;
                Price.Text = productsList.ElementAt(0).UnitPrice.ToString() + " $";
            }
            else
            {
                ClearImgForm(0);
                lbl_Laptopname.Text = "";
                Price.Text = "";
            }
        }
        private Laptop selectedLaptop;
        private void MyUserControl_UserControlButtonClicked(object sender, EventArgs e)
        {
            selectedLaptop = (Laptop)sender;
            gunaTransition1.HideSync(guna2PictureBox1);
            guna2PictureBox1.Image = new Bitmap(Application.StartupPath +"\\Images\\"+ selectedLaptop.urlImg);
            string subFolderName = selectedLaptop.name;
            if (selectedLaptop.SubImgs != null)
            {
                ClearImgForm(selectedLaptop.SubImgs.Count);
                for (int i = 0; i < selectedLaptop.SubImgs.Count; i++)
                {
                    if (i == 0)
                    {
                        gunaPictureBox1.Image = new Bitmap(Application.StartupPath + "\\Images\\" + subFolderName + "\\" + selectedLaptop.SubImgs.ElementAt(i));
                    }
                    if (i == 1)
                    {
                        gunaPictureBox2.Image = new Bitmap(Application.StartupPath + "\\Images\\" + subFolderName + "\\" + selectedLaptop.SubImgs.ElementAt(i));
                    }
                    if (i == 2)
                    {
                        gunaPictureBox3.Image = new Bitmap(Application.StartupPath + "\\Images\\" + subFolderName + "\\" + selectedLaptop.SubImgs.ElementAt(i));
                    }
                    if (i == 3)
                    {
                        gunaPictureBox4.Image = new Bitmap(Application.StartupPath + "\\Images\\" + subFolderName + "\\" + selectedLaptop.SubImgs.ElementAt(i));
                    }
                }
            }
            lbl_Laptopname.Text = selectedLaptop.name;
            Price.Text = selectedLaptop.unitprice.ToString() + " $";
            gunaTransition1.ShowSync(guna2PictureBox1);
            SelectedItem = selectedLaptop.name;
        }
        private new void TextChanged()
        {
            int Total = 0;
            foreach (var p in cartProducts)
            {
                Total += p.UnitInStock;
            }
            if (Total > 0)
            {
                btn_AddToCart.Text = "Add To Cart (" + Total + ")";
            }
            else
            {
                btn_AddToCart.Text = "Add To Cart";
            }
        }

        private void frmShop_Load(object sender, EventArgs e)
        {
            loadPanel();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (Login)
            {
                if (SelectedItem != "")
                {
                    for (int i = 0; i < cartProducts.Count; i++)
                    {
                        if (SelectedItem.Equals(cartProducts.ElementAt(i).ProductName))
                        {
                            cartProducts.ElementAt(i).UnitInStock++;
                            productsPresenter.setCartProduct();
                            break;
                        }
                    }
                }
                else
                {
                    Nofitication nofitication = new Nofitication("Select an item");
                    nofitication.ShowDialog();
                }
                TextChanged();
            }
            else
            {
                Nofitication nofitication = new Nofitication("Login required");
                nofitication.ShowDialog();
            }
        }
        private GunaPictureBox selectedImg;
        private void frmShop_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (selectedImg != null)
            {
                selectedImg.BorderStyle = BorderStyle.None;
                selectedImg = (GunaPictureBox)sender;
                selectedImg.BorderStyle = BorderStyle.FixedSingle;
                guna2PictureBox1.Image = selectedImg.Image;
            }
            else
            {
                selectedImg = (GunaPictureBox)sender;
                selectedImg.BorderStyle = BorderStyle.FixedSingle;
                guna2PictureBox1.Image = selectedImg.Image;
            }
        }

        private void btn_OpenBrand_Click(object sender, EventArgs e)
        {
            if (!guna2ShadowPanel11.Visible) guna2Transition1.ShowSync(guna2ShadowPanel11);
            else guna2Transition1.HideSync(guna2ShadowPanel11);
        }

        private void btn_CloseBrand_Click(object sender, EventArgs e)
        {
            guna2Transition2.HideSync(guna2ShadowPanel11);
        }
        private void getProductByBrand(int ID)
        {
            brandID = ID;
            productsPresenter.getProductByBrand();
            loadPanel();
        }

        private void lenovoBrand_Click(object sender, EventArgs e)
        {
            getProductByBrand(1);
        }

        private void hpBrand_Click(object sender, EventArgs e)
        {
            getProductByBrand(3);
        }

        private void asusBrand_Click(object sender, EventArgs e)
        {
            getProductByBrand(5);
        }

        private void acerBrand_Click(object sender, EventArgs e)
        {
            getProductByBrand(4);
        }

        private void msiBrand_Click(object sender, EventArgs e)
        {
            getProductByBrand(2);
        }
        private void getAll_Click(object sender, EventArgs e)
        {
            getProductByBrand(0);
        }

        private void lbl_search_TextChanged(object sender, EventArgs e)
        {
            searchText = lbl_search.Text;
            productsPresenter.getSearchProducts();
            loadPanel();
        }
    }
}
