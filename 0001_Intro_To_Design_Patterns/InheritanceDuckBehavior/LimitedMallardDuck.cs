using System;

namespace DuckExample
{
    public class LimitedMallardDuck : LimitedDuck, Flyable, Quackable
    {
        public override void Display()
        {
            Console.WriteLine("Looks like a Mallrd Duck.");
        }

        public void Fly()
        {
            Console.WriteLine("Mallard Duck Flying.");
        }

        public void Quack()
        {
            Console.WriteLine("Mallard Duck Quacking.");
        }
    }
}