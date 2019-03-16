using System;

namespace RefactoredDuckBehavior
{
    public abstract class Duck
    {
        public IQuackBehavior QuackBehavior
        {
            get;
            set;
        }

        public IFlyBehaviour FlyBehavior
        {
            get;
            set;
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

        public void SetFlyBehavior(IFlyBehaviour flyBehaviour)
        {
            FlyBehavior = flyBehaviour;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            QuackBehavior = quackBehavior;
        }
    }
}