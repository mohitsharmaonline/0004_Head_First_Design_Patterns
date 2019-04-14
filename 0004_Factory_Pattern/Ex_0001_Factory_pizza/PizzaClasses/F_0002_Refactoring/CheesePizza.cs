using IngrediantFactoryClasses;
using PizzaClasses.F_0000_ProblemCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaClasses.F_0002_Refactoring
{
    public class CheesePizza : Pizza
    {
        private readonly IPizzaIngredienFactory _ingredienFactory;

        public CheesePizza(IPizzaIngredienFactory ingredienFactory)
        {
            _ingredienFactory = ingredienFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            _dough = _ingredienFactory.CreateDough();
            _sauce = _ingredienFactory.CreateSauce();
            _cheese = _ingredienFactory.CreateCheese();
        }
    }
}
