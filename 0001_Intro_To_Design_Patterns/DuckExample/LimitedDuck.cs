using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckExample
{
    public abstract class LimitedDuck
    {
        public virtual void Swim()
        {
            Console.WriteLine("Swimiing duck");
        }

        public virtual void Display()
        {
            Console.WriteLine("Default Duck display.");
        }
    }
}