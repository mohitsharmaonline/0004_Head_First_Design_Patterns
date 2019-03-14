using System;

namespace RefactoredDuckBehavior
{
    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Can't fly..");
        }
    }
}