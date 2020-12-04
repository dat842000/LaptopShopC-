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

        public frmUserProfile()
        {
            InitializeComponent();
            userProfilePresenter = new UserProfilePresenter(this);
            userProfilePresenter.DisplayInfo();
            
        }

        public string UserImg { get => throw new NotImplementedException(); set { pictureProfile.Image = new Bitmap(Application.StartupPath + "\\Images\\UserProfileImg\\" +value); } }
        public string FullName { get => throw new NotImplementedException(); set { txt_FullName.Text = value; } }
        public string Email { get => throw new NotImplementedException(); set { txt_Email.Text = value; } }
        public bool Gender { get => throw new NotImplementedException(); set { ck_Gender.Checked = value; } }
        public string Phone { get => throw new NotImplementedException(); set { txt_Phone.Text = value; } }
        public string Address { get => throw new NotImplementedException(); set { txt_Address.Text = value; } }

    }
}
