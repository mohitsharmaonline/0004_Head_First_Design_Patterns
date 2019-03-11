using System;

namespace DuckExample
{
    public abstract class Duck
    {
        public virtual void quack()
        {
            Console.WriteLine("duck Quack quack sound.");
        }

        public void swim()
        {
            Console.WriteLine("Swimiing duck");
        }

        public virtual void display()
        {
            Console.WriteLine("Default Duck display.");
        }

        public virtual void fly()
        {
            Console.WriteLine("default duck flight.");
        }
    }
}