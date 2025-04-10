using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Lorry:Vehicle
    {
        public int MaxLoad { get; set;  }
        public Lorry(double price, int maxSpeed, int year, int maxLoad)
            :base(price, maxSpeed, year)
        {
            MaxLoad = maxLoad;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"[Грузовик] Цена: { Price}\nМаксимальная скорость:{ MaxSpeed}\nГод производства: { Year}\nМаксимальная емкость: {MaxLoad}");
            
        }
    }
}
