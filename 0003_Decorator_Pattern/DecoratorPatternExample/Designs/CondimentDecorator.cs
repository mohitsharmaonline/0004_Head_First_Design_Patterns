using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Designs
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract Beverage Beverage
        {
            get;
        }

        public abstract new string GetDescription();
    }
}