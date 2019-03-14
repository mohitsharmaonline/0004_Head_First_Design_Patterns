using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoredDuckBehavior
{
    public class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Decoy Duck Display.");
        }
    }
}