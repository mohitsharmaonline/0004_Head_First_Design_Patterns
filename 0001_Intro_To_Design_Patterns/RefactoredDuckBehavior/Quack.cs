using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoredDuckBehavior
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack quack...");
        }
    }
}