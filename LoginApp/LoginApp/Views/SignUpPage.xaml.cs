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
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage(string correo)
        {
            InitializeComponent();
            BindingContext = new SignUpPageViewModel();
            email.Text = correo;
            
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

        
        }

         
    
}