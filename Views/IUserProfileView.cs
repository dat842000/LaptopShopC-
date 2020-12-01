using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Views
{
    public interface IUserProfileView : IView
    {
        string UserImg { get; set; }
        string FullName { get; set; }
        string Email { get; set; }
        Boolean Gender { get; set; }
        string Address { get; set; }
    }
}
