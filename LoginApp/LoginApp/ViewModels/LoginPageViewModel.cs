using LoginApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginApp.ViewModels
{
    public class LoginPageViewModel
    {
        public User User { get; set; } = new User();
         
        public ICommand LoginCommand { get; set; }
        public ICommand SignUpPageCommand { get; set; }
         public LoginPageViewModel()
        {
            SignUpPageCommand = new Command(async() =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new SignUpPage(User.UserName));
            });

            LoginCommand = new Command(async() =>
            {
                if (string.IsNullOrEmpty(User.UserName) || string.IsNullOrEmpty(User.Password))
                {
                    await App.Current.MainPage.DisplayAlert("Warning", "Empty fields", "Ok");
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Warning", "Please Register.", "Ok");
                    await App.Current.MainPage.Navigation.PushAsync(new SignUpPage(User.UserName));
                    
                }
            });
        }
    }
}
