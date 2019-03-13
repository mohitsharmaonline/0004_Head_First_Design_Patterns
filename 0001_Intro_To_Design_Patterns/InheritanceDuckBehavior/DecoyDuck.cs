using System;

namespace DuckExample
{
    public class DecoyDuck : Duck
    {
        public override void quack()
        {
            // Do Nothing
        }

        public override void fly()
        {
            // Do Nothing
        }

        public override void display()
        {
            Console.WriteLine("Looks like Decoy duck.");
        }
    }
}