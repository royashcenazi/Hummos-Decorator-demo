using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    class BasicHummos : Hummos
    {
        public string GetDescription()
        {
            return "Plain Hummos";
        }

        public float GetPrice()
        {
            return 15;
        }
    }
}
