﻿using LoginApp.ViewModels;
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
    public partial class TopFoodPage : ContentPage
    {
        public TopFoodPage()
        {
            InitializeComponent();
            BindingContext = new TopFoodPageViewModel();
        }
    }
}