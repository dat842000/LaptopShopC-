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
    public partial class frmCart : Form, ICartView, IUserProfileView
    {
        private CartPresenter cartPresenter;
        private UserProfilePresenter ProfilePresenter;
        private List<ProductModel> cartProducts;
        private List<ProductModel> displayProducts;
        private List<OrderDetailModel> buyProducts = new List<OrderDetailModel>();
        private string _Fullname = null;
        public frmCart()
        {
            InitializeComponent();
            cartPresenter = new CartPresenter(this);
            ProfilePresenter = new UserProfilePresenter(this);
            ProfilePresenter.DisplayInfo();
            cartPresenter.Display();

            loadPanel();
        }
        public List<ProductModel> CartProducts
        {
            get
            {
                return cartProducts;
            }
            set
            {
                cartProducts = value;
            }
        }
        public List<OrderDetailModel> BuyProducts
        {
            get
            {
                return buyProducts;
            }
        }


        public string UserImg { get => throw new NotImplementedException(); set { if (value != null) { pictureProfile.Image = new Bitmap(Application.StartupPath + "\\Images\\UserProfileImg\\" + value); } } }
        public string FullName { get { return _Fullname; } set { lbl_Fullname.Text = "Fullname : " + value; } }
        public string Email { get => throw new NotImplementedException(); set { lbl_Email.Text = "Email : " + value; } }
        public bool Gender
        {
            get => throw new NotImplementedException();
            set
            {
                if (_Fullname != null)
                {
                    if (value) { lbl_Gender.Text = "Gender : Male"; }
                    else { lbl_Gender.Text = "Gender : Male"; };
                }
                else
                {
                    lbl_Gender.Text = "Gender :";
                }
            }
        }
        public string Phone { get => throw new NotImplementedException(); set { lbl_Phone.Text = "Phone : " + value; } }
        public string Address { get => throw new NotImplementedException(); set { lblAddress.Text = "Address : " + value; } }

        private void loadPanel()
        {
            displayProducts = new List<ProductModel>();
            for (int i = 0; i < cartProducts.Count; i++)
            {
                if (cartProducts.ElementAt(i).UnitInStock > 0)
                {
                    var UsersGrid = new CartItem
                    {
                        name = cartProducts.ElementAt(i).ProductName,
                        urlImg = cartProducts.ElementAt(i).ImgUrl,
                        unitprice = cartProducts.ElementAt(i).UnitPrice.ToString(),
                        Quantity = cartProducts.ElementAt(i).UnitInStock,
                    };
                    displayProducts.Add(cartProducts.ElementAt(i));
                    UsersGrid.MyForm = this;
                    UsersGrid.UserControlButtonClicked += new
                        EventHandler(MyUserControl_UserControlButtonClicked);
                    UsersGrid.changQuantity += new EventHandler(MyUserControl_changQuantity);
                    displayCartPanel.Controls.Add(UsersGrid);
                }
            }
            TextChanged();

        }
        private CartItem selectedUser;
        private static int breakFlag = 0;
        private void MyUserControl_changQuantity(object sender, EventArgs e)
        {
            selectedUser = (CartItem)sender;
            for (int i = 0; i < displayProducts.Count; i++)
            {
                if (selectedUser.name.Equals(displayProducts.ElementAt(i).ProductName))
                {
                    displayProducts.ElementAt(i).UnitInStock = selectedUser.Quantity;
                    breakFlag = 1;
                    break;
                }

            }

            TextChanged();
        }
        private void MyUserControl_UserControlButtonClicked(object sender, EventArgs e)
        {
            if (breakFlag == 0)
            {
                selectedUser = (CartItem)sender;
                for (int i = 0; i < displayProducts.Count; i++)
                {
                    if (selectedUser.name.Equals(displayProducts.ElementAt(i).ProductName))
                    {
                        displayCartPanel.Controls.RemoveAt(i);
                        displayProducts.RemoveAt(i);
                        breakFlag = 1;
                        break;
                    }
                }
                for (int i = 0; i < cartProducts.Count; i++)
                {
                    if (selectedUser.name.Equals(cartProducts.ElementAt(i).ProductName))
                    {
                        cartProducts.ElementAt(i).UnitInStock = 0;
                        breakFlag = 1;
                        break;
                    }
                }
            }
            else
            {
                breakFlag = 0;
            }
            TextChanged();
        }

        private new void TextChanged()
        {
            Double subTotal = 0;
            for (int i = 0; i < displayProducts.Count; i++)
            {
                subTotal += displayProducts.ElementAt(i).UnitPrice * displayProducts.ElementAt(i).UnitInStock;

            }
            Total.Text = "Total : " + subTotal + " $";
        }





        private void btn_Buy_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cartProducts.Count; i++)
            {
                if (cartProducts.ElementAt(i).UnitInStock > 0)
                {
                    OrderDetailModel detail = new OrderDetailModel
                    {
                        ProductID = cartProducts.ElementAt(i).ProductID,
                        UnitPrice = cartProducts.ElementAt(i).UnitPrice,
                        Quantity = cartProducts.ElementAt(i).UnitInStock,
                        ImgUrl = cartProducts.ElementAt(i).ImgUrl,
                        OrderStatus = "Pending",
                        OrderDate = DateTime.Now,
                        Specs = cartProducts.ElementAt(i).Specs
                    };
                    buyProducts.Add(detail);
                    cartProducts.ElementAt(i).UnitInStock = 0;
                    displayCartPanel.Controls.RemoveAt(0);
                }
            }
            cartPresenter.setBuyProducts();
            buyProducts = new List<OrderDetailModel>();
            cartPresenter.setCartProduct();
            TextChanged();
            loadPanel();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }
    }
}
