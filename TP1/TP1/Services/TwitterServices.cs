using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TP1.Models;

namespace TP1.Services
{
    public class TwitterServices : ITwitterServices
    {


        public bool Authenticate(string User, string password)
        {
            UserModel u1 = new UserModel { Login = "Jack", Password = "mypassword" };
            UserModel u2 = new UserModel { Login = "Nick", Password = "NickPass" };
            UserModel u3 = new UserModel{Login = "John", Password = "Johnpass"};
            List<UserModel> liste = new List<UserModel>();
            liste.Add(u1);
            liste.Add(u2);
            liste.Add(u3);
            if(User == "Jack" && password == "mypassword")
            {
                return true;
            }
            return false;

        }

        public List<TweetModel> GetTweet
        {
            get
            {
                UserModel user = new UserModel() { Login = "test", Password = "password" };
                return new List<TweetModel>()
                {
                    new TweetModel(){User = user, Data ="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque ", CreatedAt = DateTime.Now},
                    new TweetModel(){User = user, Data ="Quisque auctor orci a orci posuere, quis sollicitudin urna rutrum. Phasellus pulvinar, lacus sit amet consequat pretium, elit diam faucibus nisl, quis ornare justo risus sit amet dolor. Nam sed massa vitae", CreatedAt = DateTime.Now},
                    new TweetModel(){User = user, Data ="maximus arcu lectus at lectus", CreatedAt = DateTime.Now},
                    new TweetModel(){User = user, Data ="Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Fusce ipsum nisl, accumsan ac diam sed, scelerisque tempus sapien.", CreatedAt = DateTime.Now},
                    new TweetModel(){User = user, Data ="Praesent eu", CreatedAt = DateTime.Now}
                };
            }
        }
    }
}
