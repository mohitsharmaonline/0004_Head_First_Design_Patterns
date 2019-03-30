using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Designs
{
    public class WeatherData : ISubject
    {
        public List<IObserver> IObservers { get; set; }

        public decimal GetTemperature()
        {
            return 0;
        }

        public decimal GetHumidity()
        {
            return 0;
        }

        public decimal GetPressure()
        {
            return 0;
        }

        public void MeasurementsChanged()
        {
        }

        public void RegisterObserver()
        {
        }

        public void RemoveObserver()
        {
        }

        public void NotifyObservers()
        {
        }
    }
}