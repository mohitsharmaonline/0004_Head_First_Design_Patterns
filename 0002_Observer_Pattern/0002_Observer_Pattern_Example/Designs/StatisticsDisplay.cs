using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Designs
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        public WeatherData WeatherData
        {
            get;
            set;
        }

        public void Display()
        {
        }

        public void Update()
        {
        }
    }
}