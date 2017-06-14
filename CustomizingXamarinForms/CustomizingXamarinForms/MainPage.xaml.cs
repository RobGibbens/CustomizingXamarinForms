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
		            registerLabel.Text = "Register this iOS device";
		            break;
		        case Device.Android:
		            registerLabel.Text = "Register this Android tablet";
		            break;
		        case Device.Windows:
		            registerLabel.Text = "Register this Windows device";
		            break;
		    }
        }

        async void SignDocument_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SignaturePage());
        }

	    private void Save_OnClicked(object sender, EventArgs e)
	    {
	        
	    }
	}
}