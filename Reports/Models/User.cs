using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reports.Models
{
    public class User
    {
        public User(string login, string password, bool accessReport1, bool accessReport2)
        {
            this.Login = login;
            this.Password = password;
            this.AccessReport1 = accessReport1;
            this.AccessReport2 = accessReport2;
        }
        public User() { }
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool AccessReport1 { get; set; }
        public bool AccessReport2 { get; set; }
    }
}