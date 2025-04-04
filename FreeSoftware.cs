using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class FreeSoftware : Software
    {
        public FreeSoftware(string name, string manufacturer)
            : base(name, manufacturer) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Название: {Name}\nПроизводитель: {Manufacturer}");
        }

        public override string CheckUsage()
        {
            return "Доступно для использования в любое время.";
        }
    }
}
