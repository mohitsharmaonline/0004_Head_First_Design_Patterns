using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PizzaClasses.F_0000_ProblemCode;

namespace PizzaClasses.F_0001_Refactoring
{
    public class NYStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type == "cheese")
            {
                pizza = new NYStyleCheesePizza();
            }
            else if (type == "pepproni")
            {
                pizza = new NYStylePepproniPizza();
            }
            else if (type == "clam")
            {
                pizza = new NYStyleClamPizza();
            }
            else if (type == "veggie")
            {
                pizza = new NYStyleVeggiePizza();
            }

            return pizza;
        }
    }
}