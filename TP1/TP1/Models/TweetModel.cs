using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Text;

namespace TP1.Models
{
    public class TweetModel
    {
        private UserModel User;
        private string TweetDate { get; set; }
        private string Message { get; set; }

        private string Nickname { get; set; }
        private String UserName { get; set; }
        private List<TweetModel> listeTweet { get; set; }

        public TweetModel(UserModel user, string TweetDate, string Message, string Nickname, string UserName)
        {
            User = User;
            TweetDate = this.TweetDate;
            Message = this.Message;
            Nickname = this.Nickname;
            UserName = this.UserName;
        }


        
    
    }
}
