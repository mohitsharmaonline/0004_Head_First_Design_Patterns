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
            Pizza pizza = null;
            // Below is the type of code that shall require
            // OrderPizza method to be modified every time
            // a new pizza is introduced or old one is removed.
            if(type == "cheese")
            {
                pizza = new CheesePizza();
            }
            else if(type == "pepproni")
            {
                pizza = new PepproniPizza();
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza();
            }
            else if (type == "veggie")
            {
                pizza = new VeggiePizza();
            }

            // below code will remain same.
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
