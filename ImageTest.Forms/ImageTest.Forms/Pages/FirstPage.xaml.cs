using ImageTest.Forms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ImageTest.Forms.Pages
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();

            _nextButton.Clicked += OnNextPage;
            _listView.ItemsSource = new string[] { "1", "2", "3" };
        }

        private async void OnNextPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }
    }
}
