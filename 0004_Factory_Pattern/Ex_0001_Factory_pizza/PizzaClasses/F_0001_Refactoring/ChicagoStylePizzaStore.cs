using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PizzaClasses.F_0000_ProblemCode;

namespace PizzaClasses.F_0001_Refactoring
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type == "cheese")
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else if (type == "pepproni")
            {
                pizza = new ChicagoStylePepproniPizza();
            }
            else if (type == "clam")
            {
                pizza = new ChicagoStyleClamPizza();
            }
            else if (type == "veggie")
            {
                pizza = new ChicagoStyleVeggiePizza();
            }

            return pizza;
        }
    }
}