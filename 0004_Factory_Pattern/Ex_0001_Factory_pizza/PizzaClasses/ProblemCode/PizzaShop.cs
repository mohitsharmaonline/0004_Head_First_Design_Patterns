using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaClasses.ProblemCode
{
    public class PizzaShop
    {
        public Pizza OrderPizza(string type)
        {
            SimplePizzaFactory pizzaFactory = new SimplePizzaFactory();
            // Now only factory class shall change, Client code needs not to be changed.
            Pizza pizza = pizzaFactory.CreatePizza(type);

            // below code will remain same.
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
