using System;

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

