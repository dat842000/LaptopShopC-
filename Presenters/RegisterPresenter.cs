using ProjectCsharp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Presenters
{
    public class RegisterPresenter : Presenter<ILoginView>
    {
        public RegisterPresenter(ILoginView view) : base(view)
        {
        }
        public void register()
        {
            string Username = View.Username;
            string Password = View.Password;
            string Fullname = View.Fullname;
            string Phone = View.Phone;
            string Email = View.Email;
            string Address = View.Address;
            Boolean Gender = View.Gender;
            string urlImg = View.urlImg;
            if (Model.Register(Username,Password,Fullname,Phone, Email, Address, Gender, urlImg))
            {
                View.State = true;
            }
            else
            {
                View.State = false;
            }
        }
    }
}
