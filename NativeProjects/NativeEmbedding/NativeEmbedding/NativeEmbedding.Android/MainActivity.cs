using Android.App;
using Android.OS;
using Button = Android.Widget.Button;

namespace NativeEmbedding.Droid
{
    [Activity (Label = "NativeEmbedding.Android", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/MyTheme")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
                StartActivity(typeof(RegisteredDevicesActivity));
			};
		}
	}
}