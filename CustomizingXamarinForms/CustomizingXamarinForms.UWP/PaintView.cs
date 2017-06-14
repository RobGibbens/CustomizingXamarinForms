using System;
using Windows.UI;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml.Controls;

namespace CustomizingXamarinForms.UWP
{
    public class PaintView : InkCanvas
    {
        public event EventHandler LineDrawn;
        public PaintView()
        {
            InkPresenter.InputDeviceTypes = Windows.UI.Core.CoreInputDeviceTypes.Mouse | Windows.UI.Core.CoreInputDeviceTypes.Pen | Windows.UI.Core.CoreInputDeviceTypes.Touch;

            InkPresenter.StrokesCollected += OnStrokesCollected;
        }

        void OnStrokesCollected(object sender, InkStrokesCollectedEventArgs args)
        {
            LineDrawn?.Invoke(this, EventArgs.Empty);
        }

        public void SetInkColor(Color inkColor)
        {
            var attributes = new InkDrawingAttributes();
            attributes.Color = inkColor;
            InkPresenter.UpdateDefaultDrawingAttributes(attributes);
        }

        public void Clear()
        {
            InkPresenter.StrokeContainer.Clear();
        }
    }
}