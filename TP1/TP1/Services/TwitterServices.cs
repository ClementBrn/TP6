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
        private static UserModel Uer = new UserModel("Jean", "Jacques");
        private static TweetModel model = new TweetModel(Uer, "00/00/00", "Recupere la liste", "su", "uusseerr");
        
        
        public bool Authenticate(string User, string password)
        {
            UserModel userModel = new UserModel(User, Password);
            UserModel u1 = new UserModel("Jack", "mypassword");
            UserModel u2 = new UserModel("Nick", "NickPass");
            UserModel u3 = new UserModel("John", "Johnpass");
            List<UserModel> liste = new List<UserModel>();
            liste.Add(u1);
            liste.Add(u2);
            liste.Add(u3);
            if(liste.Contains(userModel))
            {
                return true;
            }
            return false;

        }

        public List<TweetModel> GetTweet()
        {
            List<TweetModel> liste = new List<TweetModel>();
            
            TweetModel tweet1 = new TweetModel(u1, "25/06/2020", "J'aime le xamarin", "JackOCoder", "JackOCode");
            TweetModel tweet2 = new TweetModel(u2, "12/12/12", "The cake is a lie", "NicksMyName", "ImNick");
            TweetModel tweet3 = new TweetModel(u3, "01/01/00", "I'm the first", "JohnDoe", "DoeJohn");
            liste.Add(tweet1);
            liste.Add(tweet2);
            liste.Add(tweet3);
            return liste;
        }
    }
}
