using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoredDuckBehavior
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("Model Duck Display.");
        }
    }
}