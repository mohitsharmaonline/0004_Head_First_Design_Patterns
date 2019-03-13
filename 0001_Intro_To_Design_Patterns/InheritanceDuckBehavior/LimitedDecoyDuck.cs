using System;

namespace DuckExample
{
    public class LimitedDecoyDuck : LimitedDuck
    {
        public override void Display()
        {
            Console.WriteLine("Looks like Decoy duck.");
        }
    }
}