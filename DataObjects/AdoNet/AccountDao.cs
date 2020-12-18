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

        public Account GetAccount(string Username, string Password)
        {
            string sql =
            @" SELECT AccountID, Username, Pass, FullName, Email, Address, Gender, Phone, UserImg, Role
                 FROM [Account]
                WHERE Username = @Username AND Pass = @Password";

            object[] parms = { "@Username", Username, "@Password", Password };
            return db.Read(sql, Make, parms).FirstOrDefault();
        }
        public Account CheckUserNameDuplicate(string Username)
        {
            string sql =
            @" SELECT AccountID
                 FROM [Account]
                WHERE Username = @Username";

            object[] parms = { "@Username", Username};
            return db.Read(sql, MakeID, parms).FirstOrDefault();
        }
        public Account GetAccountByID(int AccountID)
        {
            string sql =
            @" SELECT AccountID, Username, Pass, FullName, Email, Address, Gender, Phone, UserImg, Role
                 FROM [Account]
                WHERE AccountID = @AccountID ";

            object[] parms = { "@AccountID", AccountID};
            return db.Read(sql, Make, parms).FirstOrDefault();
        }

        public void InsertAccount(Account Account)
        {
            string sql =
            @"INSERT INTO [Account] (Username, Pass, FullName, Email, Address, Gender, Phone, UserImg, Role) 			
              VALUES (@Username, @Pass, @FullName, @Email, @Address, @Gender, @Phone, @UserImg, @Role)";

            Account.AccountID = db.InsertIdentity(sql, Take(Account));

        }

        //public void UpdateAccount(Account Account)
        //{
        //    string sql =
        //    @"UPDATE [Member]
        //         SET Email = @Email, 
        //             CompanyName = @CompanyName,
        //             City = @City,
        //             Country = @Country
        //       WHERE MemberId = @MemberId";


        //    db.Update(sql, Take(Account));
        //}
        // creates a Member object based on DataReader
        //AccountID, Username, Pass, FullName, Email, Address
        static Func<IDataReader, Account> MakeID = reader =>
           new Account
           {
               AccountID = reader["AccountID"].AsId(),
           };
        static Func<IDataReader, Account> Make = reader =>
           new Account
           {
               AccountID = reader["AccountID"].AsId(),
               Username = reader["Username"].AsString(),
               Pass = reader["Pass"].AsString(),
               UserImg = reader["UserImg"].AsString(),
               FullName = reader["FullName"].AsString(),
               Email = reader["Email"].AsString(),
               Address = reader["Address"].AsString(),
               Gender = reader["Gender"].AsBool(),
               Phone = reader["Phone"].AsString(),
               Role = reader["Role"].AsString()
           };

        // creates a Members object with order statistics based on DataReader



        // creates query parameters list from Member object

        object[] Take(Account Account)
        {
            return new object[]
            {
                "@AccountID", Account.AccountID,
                "@Username", Account.Username,
                "@Pass", Account.Pass,
                "@UserImg",Account.UserImg,
                "@FullName", Account.FullName,
                "@Email", Account.Email,
                "@Phone", Account.Phone,
                "@Gender",Account.Gender,
                "@Address", Account.Address,
                "@Role", "Guest"
            };
        }
    }
}
