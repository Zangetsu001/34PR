using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class CommercialSoftware:Software
    {
        public decimal Price { get; set; }
        public DateTime InstallationDate { get; set; }
        public int UsagePeriod { get; set; } 

        public CommercialSoftware(string name, string manufacturer, decimal price, DateTime installationDate, int usagePeriod)
            : base(name, manufacturer)
        {
            Price = price;
            InstallationDate = installationDate;
            UsagePeriod = usagePeriod;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}\nПроизводитель: {Manufacturer}\nЦена: {Price}\nДата установки: {InstallationDate.ToShortDateString()}\nСрок использования: {UsagePeriod} дней");
        }

        public override string CheckUsage()
        {
            var currentDate = DateTime.Now;
            var usagePeriodEnd = InstallationDate.AddDays(UsagePeriod);

            if (currentDate <= usagePeriodEnd)
            {
                return "Доступно для использования.";
            }
            else
            {
                return "Срок использования истек.";
            }
        }
    }
}
