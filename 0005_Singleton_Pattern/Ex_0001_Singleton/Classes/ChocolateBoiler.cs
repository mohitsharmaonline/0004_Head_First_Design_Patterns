using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public sealed class ChocolateBoiler
    {
        private bool _empty;
        private bool _boiled;
        private static ChocolateBoiler _instance;

        public static ChocolateBoiler Instance => Nested.Instance;
        

        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        public bool IsEmpty => _empty;

        public bool IsBoiled => _boiled;

        public void Fill()
        {
            if(IsEmpty)
            {
                _empty = false;
                _boiled = false;
                // fill the boiler.
            }
        }

        public void Drain()
        {
            if(!IsEmpty && IsBoiled)
            {
                // drain
                _empty = true;
            }
        }

        public class Nested
        {
            static Nested()
            {
            }

            internal static readonly ChocolateBoiler Instance = new ChocolateBoiler();
        }
        
    }
}
