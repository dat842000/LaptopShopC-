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
        private List<int> choosingProducts = new List<int>();
        public frmCart()
        {
            InitializeComponent();
            cartPresenter = new CartPresenter(this);
            ProfilePresenter = new UserProfilePresenter(this);
            ProfilePresenter.DisplayInfo();
            cartPresenter.Display();
            LoadListView();
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


        public string UserImg { get => throw new NotImplementedException(); set{ pictureProfile.Image = new Bitmap(Application.StartupPath + "\\Images\\UserProfileImg\\" + value); } }
        public string FullName { get => throw new NotImplementedException(); set { lbl_Fullname.Text ="Fullname : "+ value; } }
        public string Email { get => throw new NotImplementedException(); set { lbl_Email.Text = "Email : " + value; } }
        public bool Gender
        {
            get => throw new NotImplementedException(); 
            set
            {
                if (value) { lbl_Gender.Text = "Gender : Male"; }
                else { lbl_Gender.Text = "Gender : Male"; };
            }
        }
        public string Phone { get => throw new NotImplementedException(); set { lbl_Phone.Text = "Phone : " + value; } }
        public string Address { get => throw new NotImplementedException(); set { lblAddress.Text = "Address : " + value; } }

        
        private void LoadListView()
        {
            for (int i = 0; i < cartProducts.Count; i++)
            {
                ListViewItem Product = new ListViewItem();
                Product.Text = cartProducts.ElementAt(i).ProductName;
                Product.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = cartProducts.ElementAt(i).UnitPrice.ToString() +" $" });
                Product.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = cartProducts.ElementAt(i).Specs.ToString() });
                lsvShow.Items.Add(Product);
            }
            TextChanged();
        }
        private new void TextChanged()
        {
            float subTotal = 0;
            for (int i = 0; i < cartProducts.Count; i++)
            {
                subTotal += cartProducts.ElementAt(i).UnitPrice;
            }
            Total.Text = "Total : " + subTotal + " $";
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (choosingProducts.Count > 0)
            {
                for (int i = choosingProducts.Count-1; i >=0 ; i--)
                {
                    cartProducts.RemoveAt(choosingProducts.ElementAt(i));
                    lsvShow.Items.RemoveAt(choosingProducts.ElementAt(i));
                }
                choosingProducts = new List<int>();
                btn_Delete.Text = "Delete";
                TextChanged();
            }
            else
            {
                MessageBox.Show("You have to selected an item");
            }
        }

        private void lsvShow_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            choosingProducts = new List<int>();
            foreach (ListViewItem item in lsvShow.CheckedItems)
            {
                choosingProducts.Add(item.Index);
            }
            if (choosingProducts.Count > 0) btn_Delete.Text = "Delete " + "(" + choosingProducts.Count + ")";
            else btn_Delete.Text = "Delete"; 
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < cartProducts.Count; i++)
            {
                cartProducts.ElementAt(i).OrderDate = DateTime.Now;
            }
            cartPresenter.setBuyProducts();
            cartProducts = new List<OrderDetailModel>();
            cartPresenter.setCartProduct();
            TextChanged();
            lsvShow.Items.Clear();
        }
    }
}
