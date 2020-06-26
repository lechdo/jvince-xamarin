using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpsXamarin.Entities;
using TpsXamarin.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TpsXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetsListView : ContentPage
    {
        public TweetsListView()
        {
            InitializeComponent();
            List<Tweet> liste = new TwitterService().GetTweets();
            this.TweetsList.ItemsSource = liste;
            
        }

      
    }


}