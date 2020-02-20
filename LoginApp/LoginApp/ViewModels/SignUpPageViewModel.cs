using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginApp.ViewModels
{
    public class SignUpPageViewModel
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public ICommand SignUpCommand { get; set; }
        public ICommand LoginPageCommand { get; set; }
        public SignUpPageViewModel()
        {
            LoginPageCommand = new Command(async() =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
            });

            SignUpCommand = new Command(async() =>
            {
                if (Password != RePassword)
                {
                    await App.Current.MainPage.DisplayAlert("Alert", "Passwords do not match", "Ok");
                }
                else if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(RePassword) || string.IsNullOrEmpty(Email))
                {
                    await App.Current.MainPage.DisplayAlert("Warning", "Empty fields", "Ok");
                }
                else
                {
                    
                    await App.Current.MainPage.Navigation.PushAsync(new MainPage());
                }

            });


        }

    }
}
