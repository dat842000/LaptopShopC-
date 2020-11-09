using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.AdoNet
{
    public class AccountDao : IAccountDao
    {
        static Db db = new Db();

        public Account GetAccount(int AccountID)
        {
            string sql =
            @" SELECT AccountID, Username, Pass, FullName, Email, Address
                 FROM [Account]
                WHERE AccountID = @AccountID";

            object[] parms = { "@AccountID", AccountID };
            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        public Account GetAccountByEmail(string email)
        {
            string sql =
            @" SELECT AccountID, Username, Pass, FullName, Email, Address
                 FROM [Account]
                WHERE Email = @Email";

            object[] parms = { "@Email", email };
            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        public List<Account> GetAccounts(string sortExpression)
        {
            string sql =
            @"SELECT AccountID, Username, Pass, FullName, Email, Address
                FROM [Account] ".OrderBy(sortExpression);

            return db.Read(sql, Make).ToList();
        }

        public Account GetAccountByOrder(int OrderID)
        {
            string sql =
            @" SELECT A.AccountID, Username, Pass, FullName, Email, Address
                 FROM [Order] O JOIN [Account] A ON O.MemberId = A.MemberId
                WHERE OrderID = @OrderID";

            object[] parms = { "@OrderID", OrderID };
            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        public List<Account> GetAccountWithOrderDetail(string sortExpression)
        {
            string sql =
            @"SELECT A.AccountID, Username, Pass, FullName, Email, Address,
                     MAX(OrderDate) AS LastOrderDate, COUNT(OrderId) AS NumOrders 
                FROM [Order] O JOIN [Member] C ON O.AccountID = A.AccountID
               GROUP BY A.AccountID, Username, Pass, FullName, Email, Address"
                    .OrderBy(sortExpression);

            return db.Read(sql, MakeWithStats).ToList();
        }

        public void InsertAccount(Account Account)
        {
            string sql =
            @"INSERT INTO [Account] (Username, Pass, FullName, Email, Address) 			
              VALUES (@Username, @Pass, @FullName, @Email, @Address)";

            Account.AccountID = db.Insert(sql, Take(Account));

        }

        public void UpdateAccount(Account Account)
        {
            string sql =
            @"UPDATE [Member]
                 SET Email = @Email, 
                     CompanyName = @CompanyName,
                     City = @City,
                     Country = @Country
               WHERE MemberId = @MemberId";


            db.Update(sql, Take(Account));
        }

        public void DeleteMember(Account Account)
        {
            string sql =
            @"DELETE FROM [Member]
               WHERE MemberId = @MemberId";

            db.Update(sql, Take(Account));
        }




        // creates a Member object based on DataReader
        //AccountID, Username, Pass, FullName, Email, Address

        static Func<IDataReader, Account> Make = reader =>
           new Account
           {
               AccountID = reader["AccountID"].AsId(),
               Username = reader["Username"].AsString(),
               Pass = reader["Pass"].AsString(),
               FullName = reader["Pass"].AsString(),
               Email = reader["Email"].AsString(),
               Address = reader["Address"].AsString()
           };

        // creates a Members object with order statistics based on DataReader

        static Func<IDataReader, Account> MakeWithStats = reader =>
        {
            var Account = Make(reader);
            Account.NumOrders = reader["NumOrders"].AsInt();
            Account.LastOrderDate = reader["LastOrderDate"].AsDateTime();

            return Account;
        };


        // creates query parameters list from Member object

        object[] Take(Account Account)
        {
            return new object[]
            {
                "@AccountID", Account.AccountID,
                "@Username", Account.Username,
                "@Pass", Account.Pass,
                "@FullName", Account.FullName,
                "@Email", Account.Email,
                "@Address", Account.Address
            };
        }
    }
}
}
