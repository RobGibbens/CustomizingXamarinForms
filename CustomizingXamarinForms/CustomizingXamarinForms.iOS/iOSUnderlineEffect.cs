using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace CustomizingXamarinForms.iOS
{
    public class iOSUnderlineEffect : PlatformEffect
    {
        private void AddUnderline()
        {
            var label = (UILabel)Control;

            if (label == null)
            {
                return;
            }

            var text = (NSMutableAttributedString)label.AttributedText;
            var range = new NSRange(0, text.Length);

            text.AddAttribute(UIStringAttributeKey.UnderlineStyle, NSNumber.FromInt32((int)NSUnderlineStyle.Single), range);
        }

        private void RemoveUnderline()
        {
            var label = (UILabel)Control;

            if (label == null)
            {
                return;
            }

            var text = (NSMutableAttributedString)label.AttributedText;
            var range = new NSRange(0, text.Length);

            text.RemoveAttribute(UIStringAttributeKey.UnderlineStyle, range);
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