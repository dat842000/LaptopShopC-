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
    public partial class frmUserProfile : Form, IUserProfileView
    {
        private UserProfilePresenter userProfilePresenter;
        private frmMainMenu parent;
        public frmUserProfile(frmMainMenu parent)
        {
            this.parent = parent;
            InitializeComponent();
            userProfilePresenter = new UserProfilePresenter(this);
            userProfilePresenter.DisplayInfo();

        }

        public string UserImg { get => throw new NotImplementedException(); set { pictureProfile.Image = new Bitmap(Application.StartupPath + "\\Images\\UserProfileImg\\" + value); } }
        public string FullName { get => throw new NotImplementedException(); set { lb_fullname.Text = value; } }
        public string Email { get => throw new NotImplementedException(); set { lb_email.Text = value; } }
        public bool Gender { get => throw new NotImplementedException(); set { if (value) { lb_gender.Text = "Male"; } else { lb_gender.Text = "Female"; }; } }
        public string Phone { get => throw new NotImplementedException(); set { lb_phone.Text = value; } }
        public string Address { get => throw new NotImplementedException(); set { lb_address.Text = value; } }
        public void Logout()
        {
            parent.Logout();
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            userProfilePresenter.Logout();
        }
    }
}
