using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Text;

namespace TP1.Models
{
    public class TweetModel
    {
		private UserModel user;
		private String data;
		private DateTime createdAt;

		public UserModel User
		{
			get { return user; }
			set { user = value; }
		}
		public String Data
		{
			get { return data; }
			set { data = value; }
		}
		public DateTime CreatedAt
		{
			get { return createdAt; }
			set { createdAt = value; }
		}





	}
}
