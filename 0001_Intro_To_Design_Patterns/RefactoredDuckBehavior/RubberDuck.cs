using System;

namespace RefactoredDuckBehavior
{
    public class RubberDuck : Duck
    {

        public RubberDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Squeak();
        }
        public override void Display()
        {
            Console.WriteLine("Rubber Duck Display.");
        }
    }
}