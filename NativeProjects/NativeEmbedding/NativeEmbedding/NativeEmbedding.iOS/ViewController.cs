using System;

using UIKit;
using Xamarin.Forms;

namespace NativeEmbedding.iOS
{
	public partial class ViewController : UIViewController
	{
		int count = 1;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			Button.AccessibilityIdentifier = "myButton";
			Button.TouchUpInside += delegate {
				var devicesPage = new RegisteredDevicesPage();
			    var devicesViewController = devicesPage.CreateViewController();
                NavigationController.PushViewController(devicesViewController, true);
			};
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

