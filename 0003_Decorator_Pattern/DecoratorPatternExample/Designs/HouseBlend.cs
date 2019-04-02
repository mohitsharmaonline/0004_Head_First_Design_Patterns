using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Designs
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            _description = "HouseBlend";
        }
        public override decimal Cost()
        {
            return .89M;
        }
    }
}