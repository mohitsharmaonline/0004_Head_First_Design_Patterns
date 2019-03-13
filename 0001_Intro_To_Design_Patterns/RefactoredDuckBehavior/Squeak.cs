using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoredDuckBehavior
{
    public class Squeak : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak squeak...");
        }
    }
}