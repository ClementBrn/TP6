using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Models;
using TP1.Services;
using Xamarin.Essentials;
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

        private async void Connexion_Clicked(object sender, EventArgs e)
        {
            FormModel form = new FormModel(this.login.Text.ToString(), this.password.Text.ToString());
            string login = this.login.Text.ToString();
            string password = this.password.Text.ToString();
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {


                if (twitterServices.Authenticate(login, password))
                {
                    await Navigation.PushAsync(new TweetPage());
                    ConnexionForm.IsVisible = false;
                }
                else
                {
                    LoginError.Text = "Login incorrect";
                    LoginError.IsVisible = true;
                }
            }
            else
            {
                LoginError.Text = "Vous devez être connecté à internet";
                LoginError.IsVisible = true;
            }
        }
    }
}
