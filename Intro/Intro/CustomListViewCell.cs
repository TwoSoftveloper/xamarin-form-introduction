using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Intro
{
    public class CustomListViewCell : ContentPage
    {
        public CustomListViewCell()
        {
            var customers = GetCustomers();
            var listView = new ListView
            {
                RowHeight = 50,
                ItemsSource = customers,
                ItemTemplate = new DataTemplate(typeof(CustomerCell))
            };

            Content = listView;
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer> {
            new Customer {
                DisplayName = "The Amazing Developer-Man",
                ImageUri = "https://avatars2.githubusercontent.com/u/7973560?v=3&s=460",
                Whatever = "Two Softveloper"
            },
            new Customer {
                DisplayName = "The Amazing Developer-Man",
                ImageUri = "https://avatars2.githubusercontent.com/u/7973560?v=3&s=460",
                Whatever = "Two Softveloper"
            }
        };
        }
    }

    public class CustomerCell : ViewCell
    {
        public CustomerCell()
        {
            var image = new Image
            {
                HorizontalOptions = LayoutOptions.Start
            };

            image.SetBinding(Image.SourceProperty, new Binding("ImageUri"));
            image.WidthRequest = image.HeightRequest = 50;

            var nameLayout = CreateNameLayout();
            var viewLayout = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Children = { image, nameLayout }
            };

            View = viewLayout;
        }

        static StackLayout CreateNameLayout()
        {
            var nameLabel = new Label
            {
                HorizontalOptions = LayoutOptions.StartAndExpand
            };
            nameLabel.SetBinding(Label.TextProperty, "DisplayName");

            var label = new Label
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                FontSize = 12
            };

            label.SetBinding(Label.TextProperty, "Whatever");
            var nameLayout = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Vertical,
                Children = { nameLabel, label }
            };

            return nameLayout;
        }
    }

    public class Customer
    {
        public string DisplayName { set; get; }
        public string Whatever { set; get; }
        public string ImageUri { set; get; }
    }
}
