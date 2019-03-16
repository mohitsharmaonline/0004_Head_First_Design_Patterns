using RefactoredDuckBehavior;

namespace DuckExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new RocketPoweredFlying());
            model.PerformFly();
        }       
    }
}
