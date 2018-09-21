using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hummos hummos = new MushroomHummos(new ShakShukaHummos(new BasicHummos()));

            Console.WriteLine(hummos.GetDescription());
            Console.WriteLine(hummos.GetPrice());
        }
    }
}
