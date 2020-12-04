using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Models.Models
{
    public class UserProfileModel
    {
        public int AccountID { get; set; }
        public string UserImg { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public Boolean Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
    }
}
