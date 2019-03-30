using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Designs
{
    public interface ISubject
    {
        List<IObserver> Observers { get;}

        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}