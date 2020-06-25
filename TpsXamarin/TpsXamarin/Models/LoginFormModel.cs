using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace TpsXamarin.Models
{
    class LoginFormModel
    {
        public Entry Login { get; set; }
        public Entry Password { get; set; }
        public Xamarin.Forms.Switch IsRemind { get; set; }
        public ViewSwitch ViewSwitch { get; set; }
        public ErrorFormModel ErrorForm { get; set; }

        public LoginFormModel(Entry login, Entry password, Xamarin.Forms.Switch isRemind, View loginForm, View tweetForm, Label errorLabel, Button button)
        {
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
                this.ErrorForm.ErrorLabel.IsVisible = false;
                this.ViewSwitch.Switch();
            }
        }

        public Boolean IsValid()
        {
            Boolean result = true;

            String login = this.Login.Text;
            String password = this.Password.Text;
            Boolean isRemind = this.IsRemind.IsToggled;

            StringBuilder sb = new StringBuilder();
            bool haveAlreadyAnError = false;
            String rollBack = "\n";

            if (String.IsNullOrEmpty(login) || login.Length < 3)
            {
                sb.Append("l'identifiant doit être supérieur à 3 caractères.");
                haveAlreadyAnError = true;
            }

            if (String.IsNullOrEmpty(password) || password.Length <6)
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

            return result;
        }
    }
}
