using Designs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0002_Observer_Pattern_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditions currentConditionsDisplay = new CurrentConditions(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4M);
            weatherData.SetMeasurements(82, 70, 29.2M);
            weatherData.SetMeasurements(78, 90, 29.2M);

        }
    }
}
