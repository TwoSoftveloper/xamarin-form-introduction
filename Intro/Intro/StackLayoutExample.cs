using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Intro
{
    public class StackLayoutExample : ContentPage 
    {
        public StackLayoutExample()
        {
            Padding = new Thickness(20);
            var red = new Label
            {
                Text = "Stop",
                BackgroundColor = Color.Red,
                FontSize = 20
            };

            var yellow = new Label
            {
                Text = "Slow down",
                BackgroundColor = Color.Yellow,
                FontSize = 20
            };

            var green = new Label
            {
                Text = "Go",
                BackgroundColor = Color.Green,
                FontSize = 20
            };

            Content = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                HorizontalOptions = LayoutOptions.Center,
                Orientation = StackOrientation.Horizontal,
                Children = { red, yellow, green }
            };
        }
    }
}
