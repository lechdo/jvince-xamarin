using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TpsXamarin.Models
{
    public class ViewSwitch
    {
        public View FirstVisible { get; set; }
        public View NextVisible { get; set; }

        public ViewSwitch(View FirstVisible, View nextVisible)
        {
            this.FirstVisible = FirstVisible;
            this.NextVisible = nextVisible;
        }

        public void Switch()
        {
            if (this.FirstVisible.IsVisible)
            {
                this.FirstVisible.IsVisible = false;
                this.NextVisible.IsVisible = true;
            }
            else
            {
                this.FirstVisible.IsVisible = true;
                this.NextVisible.IsVisible = false;
            }
        }
    }
}
