using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DTO
{
    public class Account
    {
        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string displayName;
        public string DisplayName
        {
            set { displayName = value; }
            get { return displayName; }
        }

        private string password;
        public string Password
        {
            set { password = value; }
            get { return password; }
        }

        private int type;
        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public Account(string userName, string displayName, int type, string password = null)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Type = type;
            this.Password = password;
        }

        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["DisplayName"].ToString();
            this.Type = (int)row["type"];
            this.Password = row["PassWord"].ToString();
        }
    }
}
