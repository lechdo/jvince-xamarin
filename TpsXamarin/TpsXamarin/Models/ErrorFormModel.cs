using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TpsXamarin.Models
{
    public class ErrorFormModel
    {
        public Label ErrorLabel { get; set; }
        public String Error { get; set; }

        public ErrorFormModel(Label errorLabel)
        {
            this.ErrorLabel = errorLabel;
            this.SetupErrorLabel();
        }

        private void SetupErrorLabel()
        {
            this.ErrorLabel.HorizontalOptions = LayoutOptions.FillAndExpand;
            this.ErrorLabel.IsVisible = false;
        }

        public void Show()
        {
            this.ErrorLabel.Text = Error;
            this.ErrorLabel.IsVisible = true;
        }

    }


}
