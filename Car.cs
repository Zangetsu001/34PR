using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Car:Vehicle
    {
        public int HorsePower { get; set; }
        public Car(double price, int maxSpeed, int year, int horsePower)
            :base(price, maxSpeed, year)
        {
            HorsePower = horsePower;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"[Машина] Цена: {Price}\tМаксимальная скорость:{MaxSpeed}\tГод производства: {Year}\tМощность автомобиля: {HorsePower}");
        }
    }
}
