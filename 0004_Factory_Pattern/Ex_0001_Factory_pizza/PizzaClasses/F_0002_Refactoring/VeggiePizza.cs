﻿using IngrediantFactoryClasses;
using PizzaClasses.F_0000_ProblemCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaClasses.F_0002_Refactoring
{
    public class VeggiePizza : Pizza
    {
        private readonly IPizzaIngredienFactory _pizzaIngredienFactory;

        public VeggiePizza(IPizzaIngredienFactory pizzaIngredienFactory)
        {
            _pizzaIngredienFactory = pizzaIngredienFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            _dough = _pizzaIngredienFactory.CreateDough();
            _sauce = _pizzaIngredienFactory.CreateSauce();
            _cheese = _pizzaIngredienFactory.CreateCheese();
            _clams = _pizzaIngredienFactory.CreateClam();
            _veggies = _pizzaIngredienFactory.CreateVeggies();
        }
    }
}
