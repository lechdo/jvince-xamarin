using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpsXamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TpsXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
            new LoginFormModel(this.login, this.password, this.isRemind, this.errorLabel, this.button, this.Navigation);
        }
    }
}