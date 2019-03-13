using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckExample
{
    public class LimitedRubberDuck : LimitedDuck, Quackable
    {
        public void Quack()
        {
            Console.WriteLine("Squeak Squeak.");
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a Rubber Duck.");
        }
    }
}