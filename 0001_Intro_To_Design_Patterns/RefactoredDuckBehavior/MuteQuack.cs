using System;

namespace RefactoredDuckBehavior
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Mute: No Sound.");
        }
    }
}