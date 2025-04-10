using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            while (true)
            {
                int i = 0;
                Console.WriteLine(@"Выберете нужное Вам действие:
                1. Добавить в список велосипед
                2. Добавить в список машину
                3. Добавить в список грузовик
                4. Вывести все велосипеды из списка
                5. Вывести все машины из списка
                6. Вывести все грузовики из списка
                7. Выход");
       
                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                }
                catch { }
                switch (i)
                {
                    case 1:
                        garage.AddBicycle();
                        break;
                    case 2:
                        garage.AddCar();
                        break;
                    case 3:
                        garage.AddLorry();
                        break;
                    case 4:
                        Console.WriteLine("Велосипеды:");
                        garage.GetAllBicycle();
                        break;
                    case 5:
                        Console.WriteLine("Машины:");
                        garage.GetAllCar();
                        break;
                    case 6:
                        Console.WriteLine("Грузовики:");
                        garage.GetAllLorry();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("");
                        break;
                       


                }
            }
            
        }
    }
}
