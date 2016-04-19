using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Intro
{
    public class ListViewExample : ContentPage
    {
        public ListViewExample()
        {
            var listView = new ListView();
            listView.ItemsSource = new string[]
            {
                "Top", "Two", "Three", "Four"
            };

            Content = new StackLayout
            {
                Children = { listView }
            };
        }
    }
}
