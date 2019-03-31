using System;

namespace Designs
{
    public class HeatIndexDisplay : IObserver, IDisplayElement
    {
        private readonly ISubject _weathareData;
        private decimal _heatIndex = 0.0M;

        public HeatIndexDisplay(ISubject weatherData)
        {
            _weathareData = weatherData;
            _weathareData.RegisterObserver(this);
        }

        public ISubject weatherData
        {
            get
            {
                return _weathareData;
            }
        }

        public void Display()
        {
            Console.WriteLine($"Heat index is: {_heatIndex}");
        }

        public void Update(decimal temperature, decimal humidity, decimal pressure)
        {
            _heatIndex = ComputeHeatIndex(temperature, humidity);
            Display();
        }

        private decimal ComputeHeatIndex(decimal temperature, decimal relativeHumidity)
        {
            decimal index = (decimal)((16.923M + (0.185212M * temperature) + (5.37941M * relativeHumidity) - (0.100254M * temperature * relativeHumidity)
                + (0.00941695M * (temperature * temperature)) + (0.00728898M * (relativeHumidity * relativeHumidity))
                + (0.000345372M * (temperature * temperature * relativeHumidity)) - (0.000814971M * (temperature * relativeHumidity * relativeHumidity)) +
                (0.0000102102M * (temperature * temperature * relativeHumidity * relativeHumidity)) - (0.000038646M * (temperature * temperature * temperature)) + (0.0000291583M *
                (relativeHumidity * relativeHumidity * relativeHumidity)) + (0.00000142721M * (temperature * temperature * temperature * relativeHumidity)) +
                (0.000000197483M * (temperature * relativeHumidity * relativeHumidity * relativeHumidity)) - (0.0000000218429M * (temperature * temperature * temperature * relativeHumidity * relativeHumidity)) +
                0.000000000843296M * (temperature * temperature * relativeHumidity * relativeHumidity * relativeHumidity)) -
                (0.0000000000481975M * (temperature * temperature * temperature * relativeHumidity * relativeHumidity * relativeHumidity)));
            return index;
        }
    }
}