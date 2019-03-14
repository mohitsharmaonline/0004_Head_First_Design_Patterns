using System;

namespace RefactoredDuckBehavior
{
    public abstract class Duck
    {
        public IQuackBehavior QuackBehavior
        {
            get => default;
            set
            {
            }
        }

        public IFlyBehaviour FlyBehaviour
        {
            get => default;
            set
            {
            }
        }

        public virtual void Display()
        {
            Console.WriteLine("Default Duck Display.");
        }

        public virtual void Swim()
        {
            Console.WriteLine("Default Duck swimming.");
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }
    }
}