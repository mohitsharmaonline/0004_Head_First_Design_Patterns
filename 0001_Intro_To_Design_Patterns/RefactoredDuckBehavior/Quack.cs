using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoredDuckBehavior
{
    public class Quack : QuackBehavior
    {
        void QuackBehavior.Quack()
        {
            Console.WriteLine("Quack quack...");
        }
    }
}