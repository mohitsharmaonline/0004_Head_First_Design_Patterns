﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoredDuckBehavior
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak squeak...");
        }
    }
}