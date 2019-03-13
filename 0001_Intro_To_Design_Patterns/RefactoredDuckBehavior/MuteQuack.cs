using System;

namespace RefactoredDuckBehavior
{
    public class MuteQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Mute: No Sound.");
        }
    }
}