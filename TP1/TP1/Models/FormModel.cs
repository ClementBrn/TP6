using System;
using System.Collections.Generic;
using System.Text;

namespace TP1.Models
{
    class FormModel
    {
        private string login { get; }
        private string password { get; }

        public FormModel(string login, string password)
        {
            login = this.login;
            password = this.password;

        }

        public int IsValid(string login, string password)
        {
            if(login == null ||login.Length < 3 || string.IsNullOrEmpty(login))
            {
                if (password == null || password.Length < 6 || string.IsNullOrEmpty(password))
                {
                    return 3;
                }
                return 1;


            }
            if(password == null || password.Length < 6 || string.IsNullOrEmpty(password))
            {
                return 2;
            }            
            return 0;

        }
    }
}
