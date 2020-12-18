using ProjectCsharp.Models.Models;
using ProjectCsharp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Presenters
{
    public class UserProfilePresenter : Presenter<IUserProfileView>
    {
        public UserProfilePresenter(IUserProfileView view) : base(view)
        {
        }
        public void DisplayInfo()
        {
            UserProfileModel info = Model.GetUserProfile();
            View.UserImg = info.UserImg;
            View.FullName = info.FullName;
            View.Email = info.Email;
            View.Gender = info.Gender;
            View.Phone = info.Phone;
            View.Address = info.Address;
        }
        public void Logout()
        {
            Model.Logout();
            View.Logout();
        }
    }
}
