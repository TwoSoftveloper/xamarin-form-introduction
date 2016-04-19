using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Intro
{
    public class CustomListViewExample : ContentPage
    {
        public CustomListViewExample()
        {
            var listView = new ListView();
            listView.ItemsSource = new TodoItem[]
            {
                new TodoItem { Name = "หายใจ" },
                new TodoItem { Name = "iPhone 5s", Done = true},
                new TodoItem { Name = "Huawei P9" },
                new TodoItem { Name = "Huawei Talk" }
            };
            listView.ItemTemplate = new DataTemplate(typeof(TextCell));
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            listView.ItemSelected += async (s, e) =>
            {
                var todoItem = (TodoItem)e.SelectedItem;
                await DisplayAlert("Tapped!", $"{todoItem.Name} was tapped.", "OK");
            };

            Content = new StackLayout
            {
                Children = { listView }
            };
        }
    }

    class TodoItem
    {
        public string Name { get; set; }
        public bool Done { get; set; }
    }
}
