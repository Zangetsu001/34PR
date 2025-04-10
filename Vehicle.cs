using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    abstract class Vehicle
    {
        public double Price { get; set; }
        public int MaxSpeed { get; set; }
        public int Year { get; set; }
        public Vehicle(double price, int maxSpeed, int year)
        {
            Price = price;
            MaxSpeed = maxSpeed;
            Year = year;
        }
        public int GetAge()
        {
            return DateTime.Now.Year - Year;
        }
        public abstract void DisplayInfo();
        
    }
}
