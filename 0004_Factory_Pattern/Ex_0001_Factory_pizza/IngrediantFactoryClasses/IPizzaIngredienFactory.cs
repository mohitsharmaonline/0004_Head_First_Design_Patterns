using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngrediantFactoryClasses
{
    public interface IPizzaIngredienFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IVeggies[] CreateVeggies();
        IPepperoni CreatePepperoni();
        IClams CreateClam();
    }
}
