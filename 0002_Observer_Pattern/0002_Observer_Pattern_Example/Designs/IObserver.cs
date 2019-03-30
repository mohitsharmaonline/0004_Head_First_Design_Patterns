using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Designs
{
    public interface IObserver
    {
        void Update(decimal temperature, decimal humidity, decimal pressure);
    }
}