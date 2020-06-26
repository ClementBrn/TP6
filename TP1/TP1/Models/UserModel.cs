using System;
using System.Collections.Generic;
using System.Text;

namespace TP1.Models
{
    public class UserModel
    {
		private String login;
		private String password;

		public String Login
		{
			get { return login; }
			set { login = value; }
		}

		public String Password
		{
			get { return password; }
			set { password = value; }
		}
	}
}
