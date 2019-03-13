using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoredDuckBehavior
{
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Meow();
        }

        private void Meow()
        {
            Console.WriteLine("Meow Meow...");
        }
    }
}