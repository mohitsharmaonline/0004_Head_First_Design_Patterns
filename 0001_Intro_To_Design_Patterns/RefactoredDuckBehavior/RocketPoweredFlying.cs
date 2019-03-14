using System;

namespace RefactoredDuckBehavior
{
    public class RocketPoweredFlying : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Rocket powered Flight...");
        }
    }
}