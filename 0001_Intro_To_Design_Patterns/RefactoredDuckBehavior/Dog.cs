using System;

namespace RefactoredDuckBehavior
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Bark();
        }

        private void Bark()
        {
            Console.WriteLine("Bho Bho...");
        }
    }
}