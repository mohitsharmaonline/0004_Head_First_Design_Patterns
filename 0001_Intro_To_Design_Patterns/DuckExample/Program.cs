using RefactoredDuckBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = GetAnimal(); // We don't know what the actual animal subtype is
                                         // all we care is it knows how to repond to makesound.   
            animal.MakeSound();
        }

        private static Animal GetAnimal()
        {
            return new Dog();
        }
    }
}
