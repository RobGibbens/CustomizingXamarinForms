using System;
using System.Linq;
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

            AddNativeAndroidControls();
        }

        private void AddNativeAndroidControls()
        {
#if __ANDROID__
            var radioGroup =
                new Android.Widget.RadioGroup(Forms.Context)
                {
                    Orientation = Android.Widget.Orientation.Horizontal,
                    LayoutParameters =
                        new Android.Views.ViewGroup.LayoutParams(Android.Views.ViewGroup.LayoutParams.WrapContent,
                            Android.Views.ViewGroup.LayoutParams.WrapContent)
                };

            var femaleButton = new Android.Widget.RadioButton(Forms.Context)
            {
                Id = 1,
                Text = "Female"
            };
            femaleButton.SetTextColor(Android.Graphics.Color.Black);
            femaleButton.LayoutParameters = new Android.Views.ViewGroup.LayoutParams(Android.Views.ViewGroup.LayoutParams.WrapContent, Android.Views.ViewGroup.LayoutParams.WrapContent);
            radioGroup.AddView(femaleButton);


            var maleButton = new Android.Widget.RadioButton(Forms.Context)
            {
                Id = 2,
                Text = "Male"
            };
            maleButton.SetTextColor(Android.Graphics.Color.Black);
            maleButton.LayoutParameters = new Android.Views.ViewGroup.LayoutParams(Android.Views.ViewGroup.LayoutParams.WrapContent, Android.Views.ViewGroup.LayoutParams.WrapContent);
            radioGroup.AddView(maleButton);

            var otherButton = new Android.Widget.RadioButton(Forms.Context)
            {
                Id = 3,
                Text = "Other"
            };
            otherButton.SetTextColor(Android.Graphics.Color.Black);
            otherButton.LayoutParameters = new Android.Views.ViewGroup.LayoutParams(Android.Views.ViewGroup.LayoutParams.WrapContent, Android.Views.ViewGroup.LayoutParams.WrapContent);
            radioGroup.AddView(otherButton);

            var notSpecifiedButton = new Android.Widget.RadioButton(Forms.Context)
            {
                Id = 4,
                Text = "Not specified"
            };
            notSpecifiedButton.SetTextColor(Android.Graphics.Color.Black);
            notSpecifiedButton.LayoutParameters = new Android.Views.ViewGroup.LayoutParams(Android.Views.ViewGroup.LayoutParams.WrapContent, Android.Views.ViewGroup.LayoutParams.WrapContent);
            radioGroup.AddView(notSpecifiedButton);

            var xamarinFormsView = Xamarin.Forms.Platform.Android.LayoutExtensions.ToView(radioGroup);

            mainLayout.Children.RemoveAt(5);

            mainLayout.Children.Add(xamarinFormsView, 0, 5);

            mainLayout.Children.RemoveAt(5);
            var actionButton = new Android.Support.Design.Widget.FloatingActionButton(Forms.Context);

            actionButton.SetImageResource(Droid.Resource.Drawable.pencil);
            actionButton.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Xamarin.Forms.Platform.Android.ColorExtensions.ToAndroid(Color.FromHex("#d0eeaa")));

            actionButton.Click += async (s, e) =>
            {
                await Navigation.PushAsync(new SignaturePage());
            };

            var actionButtonFrame = new Android.Widget.FrameLayout(Forms.Context);
            actionButtonFrame.SetClipToPadding(false);
            actionButtonFrame.SetPadding(0, 0, 50, 50);
            actionButtonFrame.AddView(actionButton);

            var actionButtonFrameView = Xamarin.Forms.Platform.Android.LayoutExtensions.ToView(actionButtonFrame);
            actionButtonFrameView.HorizontalOptions = LayoutOptions.End;
            actionButtonFrameView.VerticalOptions = LayoutOptions.End;

            mainLayout.Children.Add(actionButtonFrameView, 0, 8);
#endif
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