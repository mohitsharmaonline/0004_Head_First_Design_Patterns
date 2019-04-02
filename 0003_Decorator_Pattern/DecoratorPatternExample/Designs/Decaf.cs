using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Designs
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            _description = "Decaf";
        }
        public override decimal Cost()
        {
            return 1.05M;
        }
    }
}