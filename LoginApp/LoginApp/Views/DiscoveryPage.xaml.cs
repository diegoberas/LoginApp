using LoginApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoveryPage : ContentPage
    {
        
        public DiscoveryPage()
        {
            InitializeComponent();
            BindingContext = new DiscoveryPageViewModel();
        }

        private void ContentPage_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }

        private void beer_Clicked(object sender, EventArgs e)
        {
            beer.BackgroundColor = Color.FromHex("#F9A602");
            pizza.BackgroundColor = Color.White;
            coffee.BackgroundColor = Color.White;
            map.BackgroundColor = Color.White;
            dine.BackgroundColor = Color.White;
            fastfood.BackgroundColor = Color.White;

        }

        private void dine_Clicked(object sender, EventArgs e)
        {
            beer.BackgroundColor = Color.White;
            pizza.BackgroundColor = Color.White;
            coffee.BackgroundColor = Color.White;
            map.BackgroundColor = Color.White;
            dine.BackgroundColor = Color.FromHex("#F9A602");
            fastfood.BackgroundColor = Color.White;
        }

        private void coffee_Clicked(object sender, EventArgs e)
        {
            beer.BackgroundColor = Color.White;
            pizza.BackgroundColor = Color.White;
            coffee.BackgroundColor = Color.FromHex("#F9A602");
            map.BackgroundColor = Color.White;
            dine.BackgroundColor = Color.White;
            fastfood.BackgroundColor = Color.White;
        }

        private void map_Clicked(object sender, EventArgs e)
        {
            beer.BackgroundColor = Color.White;
            pizza.BackgroundColor = Color.White;
            coffee.BackgroundColor = Color.White;
            map.BackgroundColor = Color.FromHex("#F9A602");
            dine.BackgroundColor = Color.White;
            fastfood.BackgroundColor = Color.White;
        }

        private void fastfood_Clicked(object sender, EventArgs e)
        {
            beer.BackgroundColor = Color.White;
            pizza.BackgroundColor = Color.White;
            coffee.BackgroundColor = Color.White;
            map.BackgroundColor = Color.White;
            dine.BackgroundColor = Color.White;
            fastfood.BackgroundColor = Color.FromHex("#F9A602");
        }

        private void pizza_Clicked(object sender, EventArgs e)
        {
            beer.BackgroundColor = Color.White;
            pizza.BackgroundColor = Color.FromHex("#F9A602");
            coffee.BackgroundColor = Color.White;
            map.BackgroundColor = Color.White;
            dine.BackgroundColor = Color.White;
            fastfood.BackgroundColor = Color.White;
        }
    }
}