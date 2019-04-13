using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaClasses.F_0000_ProblemCode
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type == "cheese")
            {
                pizza = new CheesePizza();
            }
            else if (type == "pepproni")
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

            return pizza;
        }
    }
}
