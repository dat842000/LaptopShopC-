using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public interface IAccountDao
    {
        // gets a specific Member

        Account GetAccount(string Username, string Password);
        Account GetAccountByID(int AccountID);

        // inserts a new Member
        // following insert, Member object will contain the new identifier

        void InsertAccount(Account account);
        Account CheckUserNameDuplicate(string Username);

        //// updates a Member

        //void UpdateAccount(Account account);

    }
}
