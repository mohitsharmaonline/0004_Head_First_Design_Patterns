using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Designs
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public override Beverage Beverage => _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override decimal Cost()
        {
            return .20M + _beverage.Cost();
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Mocha";
        }
    }
}