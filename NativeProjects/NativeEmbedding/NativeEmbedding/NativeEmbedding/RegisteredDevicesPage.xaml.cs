using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NativeEmbedding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisteredDevicesPage : ContentPage
    {  
        public RegisteredDevicesPage()
        {
            InitializeComponent();
            
            var viewModel = new RegisteredDevicesViewModel();

            BindingContext = viewModel;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            var device = (RegisteredDevice) e.Item;
            await DisplayAlert($"{device.UserName} selected", $"{device.Platform} {device.Version}", "OK");

            ((ListView)sender).SelectedItem = null;
        }
    }
}