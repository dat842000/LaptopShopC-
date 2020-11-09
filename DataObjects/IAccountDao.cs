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

        Account GetAccount(int AccountID);

        // gets a specific Member by email

        Account GetAccountByEmail(string email);

        // gets a sorted list of all Members

        List<Account> GetAccounts(string sortExpression = "AccountID ASC");

        // gets Member given an order

        Account GetAccountByOrder(int OrderID);

        // gets Members with order statistics in given sort order.

        List<Account> GetAccountsWithOrderStatistics(string sortExpression);

        // inserts a new Member
        // following insert, Member object will contain the new identifier

        void InsertAccount(Account account);

        // updates a Member

        void UpdateAccount(Account account);

        // deletes a Member

        void DeleteAccount(Account account);
    }
}
