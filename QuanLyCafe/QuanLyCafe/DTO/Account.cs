using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class Account
    {
        private string username;
        private string displayname;
        private string password;
        private int type;
        public Account(string username,string displayname,int type, string password = null)
        {
            this.Username = username;
            this.Displayname = displayname;
            this.Password = password;
            this.Type = type;
        }
        public Account(DataRow row)
        {
            this.Username = row["USERNAME"].ToString();
            this.Displayname = row["DISPLAYNAME"].ToString();
            this.Password = row["PASSWORD"].ToString();
            this.Type =(int)row["TYPE"];
        }
        public string Username { get => username; set => username = value; }
        public string Displayname { get => displayname; set => displayname = value; }
        public string Password { get => password; set => password = value; }
        public int Type { get => type; set => type = value; }
    }
}
