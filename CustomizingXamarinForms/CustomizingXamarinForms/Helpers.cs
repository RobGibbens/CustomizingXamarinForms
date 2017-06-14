using System;
using Xamarin.Forms;

namespace CustomizingXamarinForms
{
    public class Helpers
    {
        private readonly Random _rand = new Random();

        public Color GetRandomColor()
        {
            var color = new Color(_rand.NextDouble(), _rand.NextDouble(), _rand.NextDouble());

            return color;
        }
    }
}