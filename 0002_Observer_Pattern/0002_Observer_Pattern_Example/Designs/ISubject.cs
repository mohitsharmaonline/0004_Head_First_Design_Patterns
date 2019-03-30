using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Designs
{
    public interface ISubject
    {
        List<IObserver> IObservers { get; set; }

        void RegisterObserver();
        void RemoveObserver();
        void NotifyObservers();
    }
}