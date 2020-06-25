using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using TpsXamarin.Entities;
using TpsXamarin.Services;
using Xamarin.Forms;

namespace TpsXamarin.Models
{
    class LoginFormModel
    {
        private readonly ITwitterService twitterService;
        public Entry Login { get; set; }
        public Entry Password { get; set; }
        public Xamarin.Forms.Switch IsRemind { get; set; }
        public ViewSwitch ViewSwitch { get; set; }
        public ErrorFormModel ErrorForm { get; set; }

        private User user;

        public LoginFormModel(Entry login, Entry password, Xamarin.Forms.Switch isRemind, View loginForm, View tweetForm, Label errorLabel, Button button)
        {
            this.twitterService = new TwitterService();
            this.Login = login;
            this.Password = password;
            this.IsRemind = isRemind;
            this.ViewSwitch = new ViewSwitch(loginForm, tweetForm);
            this.ErrorForm = new ErrorFormModel(errorLabel);
            button.Clicked += ButtonClicked;

        }

        private void ButtonClicked(Object sender, EventArgs eventArgs)
        {
            Debug.WriteLine("Button clicked");
            if (this.IsValid())
            {
                if (twitterService.Authenticate(this.user))
                {
                    this.ErrorForm.ErrorLabel.IsVisible = false;
                    this.ViewSwitch.Switch();
                }
                else
                {
                    this.ErrorForm.Error = "utilisateur inconnu";
                    this.ErrorForm.Show();
                }

                
            }
        }

        public Boolean IsValid()
        {
            Boolean result = true;

            User user = new User();
            user.Pseudo = Login.Text;
            user.Password = Password.Text;
            
            Boolean isRemind = this.IsRemind.IsToggled;

            StringBuilder sb = new StringBuilder();
            bool haveAlreadyAnError = false;
            String rollBack = "\n";

            if (String.IsNullOrEmpty(user.Pseudo) || user.Pseudo.Length < 3)
            {
                sb.Append("l'identifiant doit être supérieur à 3 caractères.");
                haveAlreadyAnError = true;
            }

            if (String.IsNullOrEmpty(user.Password) || user.Password.Length <6)
            {
                if (haveAlreadyAnError)
                {
                    sb.Append(rollBack);
                }
                sb.Append("Le mot de passe doit être supérieur à 6 caractères");
                haveAlreadyAnError = true;
            }

            if (haveAlreadyAnError)
            {
                this.ErrorForm.Error = sb.ToString();
                this.ErrorForm.Show();
            }

            result = !haveAlreadyAnError;
            this.user = user;

            return result;
        }
    }
}
