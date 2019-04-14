using IngrediantFactoryClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaClasses.F_0000_ProblemCode
{
    public abstract class Pizza
    {
        private string _name;
        protected IDough _dough;
        protected ISauce _sauce;
        protected IVeggies[] _veggies;
        protected ICheese _cheese;
        protected IPepperoni _pepperoni;
        protected IClams _clams;


        public abstract void Prepare();

        protected List<string> _toppings = new List<string>();

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
                
        

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices.");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}