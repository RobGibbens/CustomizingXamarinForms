using Android.App;
using Android.OS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace NativeEmbedding.Droid
{
    [Activity(Label = "Registered Devices", Icon = "@drawable/icon",Theme = "@style/MyTheme")]
    public class RegisteredDevicesActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            FormsAppCompatActivity.ToolbarResource = Resource.Layout.toolbar;
            FormsAppCompatActivity.TabLayoutResource = Resource.Layout.tabs;

            base.OnCreate(bundle);
            SetContentView(Resource.Layout.RegisteredDevicesActivity);

            Forms.Init(this, bundle);

            var devicesFragment = new RegisteredDevicesPage().CreateFragment(this);
            var transaction = FragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.fragment_frame_layout, devicesFragment, "registeredDevices");
            transaction.Commit();
        }
    }
}