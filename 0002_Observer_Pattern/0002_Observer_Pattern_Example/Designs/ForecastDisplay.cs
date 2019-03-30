using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Designs
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private decimal _currentPressure = 29.92M;
        private decimal _lastPressure;
        private readonly ISubject _weatherData;

        public ForecastDisplay(ISubject weatherData)
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
            Console.WriteLine("Forecast: ");
            if(_currentPressure > _lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if(_currentPressure == _lastPressure)
            {
                Console.WriteLine("More of the same.");
            }
            else if(_currentPressure < _lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather.");
            }
        }

        public void Update(decimal temp, decimal humidity, decimal pressure)
        {
            var weatherData = _weatherData as WeatherData;
            if(weatherData == null)
            {
                return;
            }

            _lastPressure = _currentPressure;
            _currentPressure = weatherData.GetPressure();
            Display();
        }
    }
}