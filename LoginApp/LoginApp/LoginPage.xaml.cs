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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            
        }

        async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage(name.Text)); 
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text)||string.IsNullOrEmpty(password.Text))
            {
                await DisplayAlert("Warning", "Empty fields", "Ok");
            }
            else 
            {
                await DisplayAlert("Alert", "Please Register.", "Ok");
                await Navigation.PushAsync(new SignUpPage(name.Text));
            }
            

        }

         void Vision(object sender, EventArgs e)
         {
            imageshow.Source = !password.IsPassword ? "ojo" : "novision";
            password.IsPassword = !password.IsPassword;
         }
    }
}