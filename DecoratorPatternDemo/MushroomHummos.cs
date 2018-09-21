﻿using System;

namespace DecoratorPatternDemo
{
    class MushroomHummos : HummosDecorator
    {

        public MushroomHummos(Hummos i_Hummos) : base(i_Hummos) { }


        public override string GetDescription()
        {
            return m_Hummos.GetDescription() + " and Mushrooms";
        }

        public override float  GetPrice()
        {
            return m_Hummos.GetPrice() + 7.5f;
        }
    }
}
