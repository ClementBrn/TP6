using System;
using System.Collections.Generic;
using System.Text;

namespace TP1.Models
{
    public class UserModel
    {
        private string login { get; set; }
        private string password { get; set; }

        public UserModel(string login, string password)
        {
            login = this.login;
            password = this.password;
        }
    }
}
