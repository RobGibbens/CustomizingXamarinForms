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