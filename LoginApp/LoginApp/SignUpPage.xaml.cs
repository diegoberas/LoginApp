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
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage(string correo)
        {
            InitializeComponent();
            email.Text = correo;
            
        }

        async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        void sVision(object sender, EventArgs e)
        {
            sImageshow.Source = !spassword.IsPassword ? "ojo" : "novision";
            spassword.IsPassword = !spassword.IsPassword;
        }

        void ssVision(object sender, EventArgs e)
        {
            ssImageShow.Source = !repeatpassword.IsPassword ? "ojo" : "novision";
            repeatpassword.IsPassword = !repeatpassword.IsPassword;
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            
            if (spassword.Text != repeatpassword.Text)
            {
                await DisplayAlert("Alert", "Passwords do not match", "Ok");
            }
            else if (string.IsNullOrEmpty(user.Text) || string.IsNullOrEmpty(spassword.Text) || string.IsNullOrEmpty(repeatpassword.Text) || string.IsNullOrEmpty(email.Text))
            {
                await DisplayAlert("Warning", "Empty fields", "Ok");
            }
            else
            {
                await DisplayAlert("Congratulations", "You have registered.", "Ok");
                await Navigation.PushAsync(new MainPage());
            }
        }

         
    }
}