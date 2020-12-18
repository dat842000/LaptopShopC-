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
        private List<OrderDetailModel> cartProducts;
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
        public List<OrderDetailModel> CartProducts
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


        public string UserImg { get => throw new NotImplementedException(); set { if (value != null) { pictureProfile.Image = new Bitmap(Application.StartupPath + "\\Images\\UserProfileImg\\" + value); } } }
        public string FullName { get { return _Fullname; } set { lbl_Fullname.Text ="Fullname : "+ value; } }
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
            
            for (int i = 0; i < cartProducts.Count; i++)
            {
                var UsersGrid = new CartItem
                {
                    name = cartProducts.ElementAt(i).ProductName,
                    urlImg = cartProducts.ElementAt(i).ImgUrl,
                    unitprice = cartProducts.ElementAt(i).UnitPrice.ToString(),
                };
                UsersGrid.MyForm = this;
                UsersGrid.UserControlButtonClicked += new
                    EventHandler(MyUserControl_UserControlButtonClicked);
                displayCartPanel.Controls.Add(UsersGrid);
            }
            TextChanged();
            
        }
        private CartItem selectedUser;
        private static int breakFlag=0;
        
        private void MyUserControl_UserControlButtonClicked(object sender, EventArgs e)
        {
            if (breakFlag == 0)
            {
                selectedUser = (CartItem)sender;
                for (int i = 0; i < cartProducts.Count; i++)
                {
                    if (selectedUser.name.Equals(cartProducts.ElementAt(i).ProductName))
                    {
                        cartProducts.Remove(cartProducts.ElementAt(i));
                        displayCartPanel.Controls.RemoveAt(i);
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
            for (int i = 0; i < cartProducts.Count; i++)
            {
                subTotal += cartProducts.ElementAt(i).UnitPrice;
            }
            Total.Text = "Total : " + subTotal + " $";
        }

        

        

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < cartProducts.Count; i++)
            { 
                cartProducts.ElementAt(i).OrderDate = DateTime.Now;
                cartProducts.ElementAt(i).OrderStatus = "Pending";
                displayCartPanel.Controls.RemoveAt(0);
            }
            cartPresenter.setBuyProducts();
            cartProducts = new List<OrderDetailModel>();
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
