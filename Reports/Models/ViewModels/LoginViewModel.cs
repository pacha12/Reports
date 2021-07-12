using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reports.Models.ViewModels
{
    public class LoginViewModel
    {
        public LoginViewModel() { }
        public LoginViewModel(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}