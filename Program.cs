using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            var softwareDatabase = new List<Software>
        {
            new FreeSoftware("Notaped++", "Notepad++ Team"),
            new FreemiumSoftware("Adobe Photoshop", "Adobe", new DateTime(2025, 4, 14), 30),
            new CommercialSoftware("Microsoft Office", "Microsoft", 1000, new DateTime(2023, 12, 26), 365)
        };

            foreach (var software in softwareDatabase)
            {
                software.DisplayInfo();
                Console.WriteLine(software.CheckUsage());
                Console.WriteLine();
            }

            Console.WriteLine("Програмное обеспечение, которое доступно для использования на текущую дату:");
            foreach (var software in softwareDatabase)
            {
                if (software.CheckUsage().Contains("Доступно"))
                {
                    software.DisplayInfo();
                    Console.WriteLine(software.CheckUsage());
                    Console.WriteLine();
                    Console.Read();
                }
            }
        }
    }
}
