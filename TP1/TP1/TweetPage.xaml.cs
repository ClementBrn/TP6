using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Models;
using TP1.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace TP1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetPage : ContentPage
    {
        ITwitterServices twitterServices = new TwitterServices();
        
        public TweetPage()
        {
            InitializeComponent();
            this.ListeViewTweet.ItemsSource = new TwitterServices().GetTweet;
        }
    }
}