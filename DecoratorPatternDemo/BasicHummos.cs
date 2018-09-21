using System;

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
