using System;

namespace RefactoredDuckBehavior
{
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Flying with Wings..");
        }
    }
}