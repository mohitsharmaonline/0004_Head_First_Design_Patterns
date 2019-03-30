using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Designs
{
    public class ThirdPartyDisplay : IObserver, IDisplayElement
    {
        public WeatherData WeatherData
        {
            get;
            set;
        }

        public void Display()
        {
        }

        public void Update(decimal temp, decimal humidity, decimal pressure)
        {
        }
    }
}