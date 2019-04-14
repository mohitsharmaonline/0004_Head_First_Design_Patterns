using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngrediantFactoryClasses
{
    public class ChicagoPizzaIngredienFactory : IPizzaIngredienFactory
    {
        public ICheese CreateCheese()
        {
            return new Mozzarella();
        }

        public IClams CreateClam()
        {
            return new FrozenClam();
        }

        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = { new BlackOlives(), new Spinach(), new EggPlant() };
            return veggies;
        }
    }
}
