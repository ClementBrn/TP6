using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Models;
using Xamarin.Forms;

namespace TP1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
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
            switch (form.IsValid(login, password))
            {
                case 0:
                    ConnexionForm.IsVisible = false;
                    TweetList.IsVisible = true;
                    break;

                case 1:
                    LoginError.Text = "Login incorrect";
                    LoginError.IsVisible = true;
                    break;

                case 2:
                    PasswordError.Text = "Mot de passe incorrect";
                    PasswordError.IsVisible = true;
                    break;
                case 3:
                    LoginError.Text = "Login incorrect";
                    LoginError.IsVisible = true;
                    PasswordError.Text = "Mot de passe incorrect";
                    PasswordError.IsVisible = true;
                    break;
            }
        }
    }
}
