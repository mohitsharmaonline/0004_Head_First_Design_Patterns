﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IngrediantFactoryClasses;
using PizzaClasses.F_0000_ProblemCode;

namespace PizzaClasses.F_0001_Refactoring
{
    public class NYStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredienFactory pizzaIngredienFactory = new NYPizzaIngredienFactory();

            if (type == "cheese")
            {
                pizza = new PizzaClasses.F_0002_Refactoring.CheesePizza(pizzaIngredienFactory);
                pizza.Name = "NY Style Cheese Pizza";
            }
            else if (type == "pepproni")
            {
                pizza = new PizzaClasses.F_0002_Refactoring.PepperoniPizza(pizzaIngredienFactory);
                pizza.Name = "NY Style Pepperoni Pizza";
            }
            else if (type == "clam")
            {
                pizza = new PizzaClasses.F_0002_Refactoring.ClamPizza(pizzaIngredienFactory);
                pizza.Name = "NY Style Clam Pizza";
            }
            else if (type == "veggie")
            {
                pizza = new PizzaClasses.F_0002_Refactoring.VeggiePizza(pizzaIngredienFactory);
                pizza.Name = "NY Style Veggie Pizza";
            }

            return pizza;
        }
    }
}