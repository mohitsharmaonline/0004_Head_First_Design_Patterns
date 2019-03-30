using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Designs
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private readonly ISubject _weatherData;
        private decimal _maxTemp = 0.0M;
        private decimal _minTemp = 200M;
        private decimal _tempSum = 0.0M;
        private int _numReadings;

        public StatisticsDisplay(ISubject weatherData)
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
            Console.WriteLine($"Avg/Max/Min temperature = {(_tempSum / _numReadings)} / {_maxTemp} / {_minTemp}");
        }

        public void Update(decimal temperature, decimal humidity, decimal pressure)
        {
            var weatherData = _weatherData as WeatherData;
            if(weatherData == null)
            {
                return;
            }

            var temp = weatherData.GetTemperature();
            _tempSum += temp;
            _numReadings++;

            if(temp > _maxTemp)
            {
                _maxTemp = temp;
            }

            if(temp < _minTemp)
            {
                _minTemp = temp;
            }

            Display();
        }
    }
}