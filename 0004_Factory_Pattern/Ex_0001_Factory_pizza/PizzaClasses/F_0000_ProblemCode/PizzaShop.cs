using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaClasses.F_0000_ProblemCode
{
    public class PizzaShop
    {
        SimplePizzaFactory _factory;

        public PizzaShop(SimplePizzaFactory factory)
        {
            _factory = factory;
        }

        public SimplePizzaFactory SimplePizzaFactory
        {
            get
            {
                return _factory;
            }
        }

        public Pizza OrderPizza(string type)
        {
            // Now only factory class shall change, Client code needs not to be changed.
            Pizza pizza = _factory.CreatePizza(type);

            // below code will remain same.
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
