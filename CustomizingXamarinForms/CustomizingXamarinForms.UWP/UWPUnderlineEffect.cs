using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using CustomizingXamarinForms.UWP;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(UWPUnderlineEffect), "UnderlineEffect")]
namespace CustomizingXamarinForms.UWP
{
    public class UWPUnderlineEffect : PlatformEffect
    {
        private void AddUnderline()
        {
            var label = (TextBlock)Control;

            if (label == null)
            {
                return;
            }

            var originalText = label.Text;
            Underline ul = new Underline();
            Run run = new Run {Text = originalText};
            ul.Inlines.Add(run);
            label.Inlines.Clear();
            label.Inlines.Add(ul);
        }

        private void RemoveUnderline()
        {
            var label = (TextBlock)Control;

            if (label == null)
            {
                return;
            }

            var originalText = label.Text;
            
            Run run = new Run { Text = originalText };

            label.Inlines.Clear();
            label.Inlines.Add(run);
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
