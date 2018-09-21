using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    public abstract class HummosDecorator : Hummos
    {
        protected Hummos m_Hummos;

        public HummosDecorator(Hummos i_Hummos)
        {
            m_Hummos = i_Hummos;
        }

        public abstract string GetDescription();

        public abstract float GetPrice();
       
    }
}
