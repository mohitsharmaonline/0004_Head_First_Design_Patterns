using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Designs
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public override Beverage Beverage => _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override decimal Cost()
        {
            return .15M + _beverage.Cost();
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Soy";
        }
    }
}