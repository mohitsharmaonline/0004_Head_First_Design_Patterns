using System;

namespace DuckExample
{
    public class LimitedRedHeadDuck : LimitedDuck, Flyable, Quackable
    {
        public override void Display()
        {
            Console.WriteLine("Looks like a ReadHead duck.");
        }

        public void Fly()
        {
            Console.WriteLine("RedHeadDuck Flying.");
        }

        public void Quack()
        {
            Console.WriteLine("RedHeadDuck Quacking.");
        }
    }
}