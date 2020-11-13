using ActionService;
using ProjectCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp.Models
{
    public class Model : IModel
    {
        static Service service = new Service();
        static Model()
        {

        }
        public bool Login(string username, string password)
        {
            return true;
        }
    }
}
