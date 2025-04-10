using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Bicycle:Vehicle
    {
        public int PassangerCount { get; set; }
        public Bicycle(double price, int maxSpeed, int year, int passangerCount)
            :base(price, maxSpeed, year)
        {
            PassangerCount = passangerCount;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"[Велосипед] Цена: {Price}\nМаксимальная скорость:{MaxSpeed}\nГод производства: {Year}\nКоличество пассажиров: {PassangerCount}");
        }
    }
}
