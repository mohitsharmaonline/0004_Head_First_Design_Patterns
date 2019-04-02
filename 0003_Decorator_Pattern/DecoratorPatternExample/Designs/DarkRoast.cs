using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Designs
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            _description = "Dark Roast";
        }
        public override decimal Cost()
        {
            return .99M;
        }
    }
}