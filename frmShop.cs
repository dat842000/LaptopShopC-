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
        private List<OrderDetailModel> cartProducts;
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
        private void loadPanel()
        {
            for (int i = 0; i < productsList.Count; i++)
            {
                var UsersGrid = new Laptop
                {
                    name = productsList.ElementAt(i).ProductName,
                    urlImg = productsList.ElementAt(i).ImgUrl,
                    unitprice = productsList.ElementAt(i).UnitPrice.ToString(),
                    rating = productsList.ElementAt(i).ratingPoint,
                };
                UsersGrid.MyForm = this;
                UsersGrid.UserControlButtonClicked += new
                    EventHandler(MyUserControl_UserControlButtonClicked);
                flowPanel.Controls.Add(UsersGrid);
            }
            guna2PictureBox1.Image = new Bitmap(Application.StartupPath + "\\Images\\" + productsList.ElementAt(0).ImgUrl);
            gunaPictureBox1.Image = new Bitmap(Application.StartupPath + "\\Images\\Acer Nitro 5\\Acer Nitro 5(1).png");
            gunaPictureBox2.Image = new Bitmap(Application.StartupPath + "\\Images\\Acer Nitro 5\\Acer Nitro 5(2).png");
            gunaPictureBox3.Image = new Bitmap(Application.StartupPath + "\\Images\\Acer Nitro 5\\Acer Nitro 5(3).jpg");
            lbl_Laptopname.Text = productsList.ElementAt(0).ProductName;
            Price.Text = productsList.ElementAt(0).UnitPrice.ToString() + " $";
        }
        private Laptop selectedUser;
        private void MyUserControl_UserControlButtonClicked(object sender, EventArgs e)
        {
            selectedUser = (Laptop)sender;
            gunaTransition1.HideSync(guna2PictureBox1);
            guna2PictureBox1.Image = new Bitmap(Application.StartupPath +"\\Images\\"+ selectedUser.urlImg);
            lbl_Laptopname.Text = selectedUser.name;
            Price.Text = selectedUser.unitprice.ToString() + " $";
            gunaTransition1.ShowSync(guna2PictureBox1);
            SelectedItem = selectedUser.name;
        }
        private new void TextChanged()
        {
            if (cartProducts.Count > 0)
            {
                btn_AddToCart.Text = "Add To Cart (" + cartProducts.Count + ")";
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
                    for (int i = 0; i < productsList.Count; i++)
                    {
                        if (SelectedItem.Equals(productsList.ElementAt(i).ProductName))
                        {
                            OrderDetailModel orderDetail = new OrderDetailModel
                            {
                                ProductID = productsList.ElementAt(i).ProductID,
                                ProductName = productsList.ElementAt(i).ProductName,
                                ImgUrl = productsList.ElementAt(i).ImgUrl,
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

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            if (!guna2ShadowPanel11.Visible) guna2Transition1.ShowSync(guna2ShadowPanel11);
            else guna2Transition1.HideSync(guna2ShadowPanel11);
        }

        private void guna2CircleButton12_Click(object sender, EventArgs e)
        {
            guna2Transition2.HideSync(guna2ShadowPanel11);
        }
    }
}
