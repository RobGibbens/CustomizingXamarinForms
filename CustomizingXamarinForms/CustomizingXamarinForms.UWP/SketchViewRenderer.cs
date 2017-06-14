using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

namespace CustomizingXamarinForms.UWP
{
    class SketchViewRenderer : ViewRenderer<SketchView, PaintView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<SketchView> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var paintView = new PaintView();
                paintView.SetInkColor(GetWindowsColor(Element.InkColor));
                SetNativeControl(paintView);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == SketchView.InkColorProperty.PropertyName)
            {
                Control.SetInkColor(GetWindowsColor(Element.InkColor));
            }
        }

        Windows.UI.Color GetWindowsColor(Color color)
        {
            return Windows.UI.Color.FromArgb((byte)(255 * color.A), (byte)(255 * color.R), (byte)(255 * color.G), (byte)(255 * color.B));
        }
    }
}
