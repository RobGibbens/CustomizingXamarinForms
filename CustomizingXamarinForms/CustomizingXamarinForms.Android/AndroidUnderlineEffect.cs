using Android.Graphics;
using Android.Widget;
using CustomizingXamarinForms.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(AndroidUnderlineEffect), "UnderlineEffect")]
namespace CustomizingXamarinForms.Droid
{
    public class AndroidUnderlineEffect : PlatformEffect
    {
        private void AddUnderline()
        {
            var textView = (TextView)Control;

            textView.PaintFlags |= PaintFlags.UnderlineText;
        }

        private void RemoveUnderline()
        {
            var textView = (TextView)Control;
            textView.PaintFlags &= ~PaintFlags.UnderlineText;
        }

        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            AddUnderline();
        }

        protected override void OnAttached()
        {
            AddUnderline();
        }

        protected override void OnDetached()
        {
            RemoveUnderline();
        }
    }
}