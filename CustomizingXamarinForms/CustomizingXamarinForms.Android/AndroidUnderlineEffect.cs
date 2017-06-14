using Android.Graphics;
using Android.Widget;
using Xamarin.Forms.Platform.Android;

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