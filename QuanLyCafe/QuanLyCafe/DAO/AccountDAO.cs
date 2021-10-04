using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class AccountDAO
    {
        private static  AccountDAO instance;

        public static AccountDAO Instance {
            get { if (instance == null) instance = new AccountDAO();return instance; }
            private set { instance = value; }

        }
        private AccountDAO() { }
        public bool Login(string username,string password)
        {

            //byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            //byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            //string hasPass = "";
            //foreach (byte item in hasData)
            //{
            //    hasPass += item;
            //}
            //var list = hasData.ToString();
            //list.Reverse(); 
            string query = "USP_LogIn @username , @password";
            DataTable result = DAO.DataProvider.Instance.ExcuteQuery(query,new object[] { username,password});
            return result.Rows.Count>0;
        }
        public DTO.Account GetAccountByUsername(string username)
        {
            DataTable data = DAO.DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Account WHERE USERNAME =N'"  +username+"'");
            foreach (DataRow item in data.Rows)
            {
                return new DTO.Account(item);
            }
            return null;
        }
        public bool UpdateAccount(string username,string displayname,string password,string newpassword)
        {
            int result = DAO.DataProvider.Instance.ExcurNonQuery("EXEC dbo.USP_UpdateAccount @userName , @displayName , @passWord , @newPassword ", new object[] { username, displayname, password, newpassword });
            return result > 0;
        }

    }
}
