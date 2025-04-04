using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class FreemiumSoftware:Software
    {
        public DateTime InstallationDate { get; set; }
        public int FreeUsagePeriod { get; set; } 

        public FreemiumSoftware(string name, string manufacturer, DateTime installationDate, int freeUsagePeriod)
            : base(name, manufacturer)
        {
            InstallationDate = installationDate;
            FreeUsagePeriod = freeUsagePeriod;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}\nПроизводитель: {Manufacturer}\nДата установки: {InstallationDate.ToShortDateString()}\nСрок бесплатного использования: {FreeUsagePeriod} дней");
        }

        public override string CheckUsage()
        {
            var currentDate = DateTime.Now;
            var endOfFreePeriod = InstallationDate.AddDays(FreeUsagePeriod);

            if (currentDate <= endOfFreePeriod)
            {
                return "Доступно для бесплатного использования.";
            }
            else
            {
                return "Бесплатный срок использования завершен.";
            }
        }
    }
}
