using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Designs
{
    public class Milk : CondimentDecorator
    {
        private Beverage _beverage;

        public override Beverage Beverage => _beverage;

        public Milk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override decimal Cost()
        {
            return .10M + _beverage.Cost();
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Milk";
        }
    }
}