using System;

namespace DuckExample
{
    public class RubberDuck : Duck
    {
        public override void quack()
        {
            Console.WriteLine("Squeak Squeak.");
        }

        public override void display()
        {
            Console.WriteLine("Looks like a Rubber Duck.");
        }

        public override void fly()
        {
            // Do nothing.
        }
    }
}