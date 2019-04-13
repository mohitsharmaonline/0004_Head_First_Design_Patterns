using PizzaClasses.F_0000_ProblemCode;

namespace PizzaClasses.F_0001_Refactoring
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            _dough = "Thin Crust Dough";
            _sauce = "Marinara Sauce";

            _toppings.Add("Grated Reggiano Cheese");
        }
    }
}