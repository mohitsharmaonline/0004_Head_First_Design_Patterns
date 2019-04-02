using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Designs
{
    public abstract class Beverage
    {
        protected string _description = "Unknown Beverage";

        public string GetDescription()
        {
            return _description;
        }

        public abstract decimal Cost();           
    }
}