using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Views
{
    public interface ILoginView : IView
    {
        string UsernameLogin { get; }
        string PasswordLogin { get; }
        string Username { get; }
        string Password { get; }
        string Fullname { get; }
        string Phone { get; }
        string Email { get; }
        string Address { get; }
        Boolean Gender { get; }
        string urlImg { get; }
        Boolean State { get; set; }
        void OnLoginSuccess();
        void OnLoginFailure(string error);
       
    }
}
