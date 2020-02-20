using System;
using System.Collections.Generic;
using System.Text;

namespace LoginApp.ViewModels
{ 
    public class HomePageViewModel
    {
        public string Name { get; set; }

        public HomePageViewModel()
        {
            this.Name = "Home sweet Home";
        }

    }
}
