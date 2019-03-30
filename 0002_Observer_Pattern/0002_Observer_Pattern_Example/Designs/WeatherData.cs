using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Designs
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers;
        private decimal _temperature;
        private decimal _humidity;
        private decimal _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public List<IObserver> Observers
        {
            get
            {
                return _observers;
            }
        }

        public decimal GetTemperature()
        {
            return _temperature;
        }

        public decimal GetHumidity()
        {
            return _humidity;
        }

        public decimal GetPressure()
        {
            return _pressure;
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void SetMeasurements(decimal temperature, decimal humidity, decimal pressure)  
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }
}