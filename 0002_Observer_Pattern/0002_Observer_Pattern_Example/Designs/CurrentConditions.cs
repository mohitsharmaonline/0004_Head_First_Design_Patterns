using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Designs
{
    public class CurrentConditions : IObserver, IDisplayElement
    {
        private decimal _temperature;
        private decimal _humidity;
        private readonly ISubject _weatherData;

        public CurrentConditions(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }


        public ISubject WeatherData
        {
            get
            {
                return _weatherData;
            }
        }

        public void Display()
        {
            Console.WriteLine($"Current Conditions: temperature {_temperature}F degrees and humidity {_humidity}%");
        }

        public void Update(decimal temp, decimal humidity, decimal pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }
    }
}