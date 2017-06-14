using System;
using Xamarin.Forms;

namespace CustomizingXamarinForms
{
    public partial class MainPage : ContentPage
    {
        private Helpers helpers;
        public MainPage()
        {
            InitializeComponent();

            helpers = new Helpers();

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    switch (Device.Idiom)
                    {
                        case TargetIdiom.Phone:
                            registerLabel.Text = "Register this iPhone";
                            break;
                        case TargetIdiom.Tablet:
                            registerLabel.Text = "Register this iPad";
                            break;
                    }
                    break;
                case Device.Android:
                    switch (Device.Idiom)
                    {
                        case TargetIdiom.Phone:
                            registerLabel.Text = "Register this Android phone";
                            break;
                        case TargetIdiom.Tablet:
                            registerLabel.Text = "Register this Android tablet";
                            break;
                    }

                    break;
                case Device.Windows:
                    switch (Device.Idiom)
                    {
                        case TargetIdiom.Phone:
                            registerLabel.Text = "Register this Windows Phone";
                            break;
                        case TargetIdiom.Desktop:
                            registerLabel.Text = "Register this Windows desktop";
                            break;
                    }
                    break;
            }
        }

        async void SignDocument_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SignaturePage());
        }

        private void Save_OnClicked(object sender, EventArgs e)
        {
            registerLabel.TextColor = helpers.GetRandomColor();
        }
    }
}