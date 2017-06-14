using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace CustomizingXamarinForms.iOS
{
    class PaintView : UIImageView
    {
        public event EventHandler LineDrawn;

        UIColor inkColor = UIColor.Blue;

        public PaintView()
        {
            MultipleTouchEnabled = true;
            UserInteractionEnabled = true;
            this.Layer.BorderColor = UIColor.Black.CGColor;
            this.Layer.BorderWidth = 1f;
        }

        public void SetInkColor(UIColor color)
        {
            inkColor = color;
        }

        public void Clear()
        {
            if (Image != null)
                Image.Dispose();
            Image = new UIImage();
        }

        void DrawLine(CGPoint pt1, CGPoint pt2, UIColor color)
        {
            UIGraphics.BeginImageContext(Frame.Size);

            using (var g = UIGraphics.GetCurrentContext())
            {
                Layer.RenderInContext(g);

                var path = new CGPath();

                path.AddLines(new CGPoint[] { pt1, pt2 });

                g.SetLineWidth(3);
                color.SetStroke();

                g.AddPath(path);
                g.DrawPath(CGPathDrawingMode.Stroke);

                Image = UIGraphics.GetImageFromCurrentImageContext();
            }

            UIGraphics.EndImageContext();

            LineDrawn?.Invoke(this, EventArgs.Empty);
        }

        public override void TouchesMoved(NSSet touches, UIEvent evt)
        {
            foreach (UITouch touch in touches)
            {
                DrawLine(touch.PreviousLocationInView(this), touch.LocationInView(this), inkColor);
            }
        }
    }
}