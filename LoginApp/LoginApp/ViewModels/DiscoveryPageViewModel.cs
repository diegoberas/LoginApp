using System;
using System.Collections.Generic;
using System.Text;

namespace LoginApp.ViewModels
{
    public class DiscoveryPageViewModel
    {
        public string Beer { get; set; }
        public string Dine { get; set; }
        public string Coffee { get; set; }
        public string Map { get; set; }
        public string FastFood { get; set; }
        public string FFood { get; set; }

        public DiscoveryPageViewModel()
        {
            this.Beer = "Bar and Hotels";
            this.Dine = "Fine Dining";
            this.Coffee = "Coffee";
            this.Map = "Nearby";
            this.FastFood = "Fast Food";
            this.FFood = "Featured Food";
        }


    }
}
