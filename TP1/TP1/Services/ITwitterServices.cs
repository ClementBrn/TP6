using System;
using System.Collections.Generic;
using System.Text;
using TP1.Models;

namespace TP1.Services
{
    interface ITwitterServices
    {
        bool Authenticate(string User, string password);

        List<TweetModel> GetTweet { get; }
    }
}
