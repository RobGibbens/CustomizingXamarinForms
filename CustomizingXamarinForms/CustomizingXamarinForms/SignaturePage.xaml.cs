using System;
using Xamarin.Forms;

namespace CustomizingXamarinForms
{
	public partial class SignaturePage : ContentPage
	{
	    private Helpers helpers;
		public SignaturePage ()
		{
			InitializeComponent ();

            helpers = new Helpers();
		}

	    private void ChangeColors_OnClicked(object sender, EventArgs e)
	    {

	    }
	}
}