using System;

namespace RefactoredDuckBehavior
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            FlyBehaviour = new FlyWithWings();
            QuackBehavior = new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("Red Head Duck Display.");
        }
    }
}