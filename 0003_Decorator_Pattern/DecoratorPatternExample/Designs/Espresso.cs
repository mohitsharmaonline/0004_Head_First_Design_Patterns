using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Designs
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            _description = "Espresso";
        }
        public override decimal Cost()
        {
            return 1.99M;
        }
    }
}