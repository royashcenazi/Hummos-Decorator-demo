using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    class ShakShukaHummos : HummosDecorator
    {
        public ShakShukaHummos(Hummos i_Hummos) : base(i_Hummos) { }


        public override string GetDescription()
        {
            return m_Hummos.GetDescription() + " and Shakshuka";
        }

        public override float GetPrice()
        {
            return m_Hummos.GetPrice() + 12f;
        }
    }
}

