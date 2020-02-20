using System;
using System.Collections.Generic;
using System.Text;

namespace LoginApp.ViewModels
{
   public class ProfilePageViewModel
    {
        public string Name { get; set; }
        public ProfilePageViewModel()
        {
            this.Name = "Profile";
        }

    }
}
