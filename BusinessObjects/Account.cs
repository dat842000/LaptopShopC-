using BusinessObjects.BusinessRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Account: BusinessObject
    {
        public Account()
        {
            AddRule(new ValidateID("AccountID"));

            AddRule(new ValidateRequired("Email"));
            AddRule(new ValidateLength("Email", 1, 100));
            AddRule(new ValidateEmail("Email"));
        }
        public int AccountID { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int NumOrders { get; set; }
        public DateTime LastOrderDate { get; set; }
    }
}
