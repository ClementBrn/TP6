using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Models;
using TP1.Services;
using Xamarin.Forms;

namespace TP1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        ITwitterServices twitterServices = new TwitterServices();
        public MainPage()
        {
            InitializeComponent();
        }

        private void Connexion()
        {

        }

        private void Connexion_Clicked(object sender, EventArgs e)
        {
            FormModel form = new FormModel(this.login.Text.ToString(), this.password.Text.ToString());
            string login = this.login.Text.ToString();
            string password = this.password.Text.ToString();
            if (twitterServices.Authenticate(login, password))
            {
                ConnexionForm.IsVisible = false;
                TweetList.IsVisible = true;
                twitterServices.GetTweet();
            }
            else
            {
                    LoginError.Text = "Login incorrect";
                    LoginError.IsVisible = true;
            }
        }
    }
}
