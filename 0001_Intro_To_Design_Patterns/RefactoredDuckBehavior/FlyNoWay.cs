using System;

namespace RefactoredDuckBehavior
{
    public class FlyNoWay : FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Can't fly..");
        }
    }
}