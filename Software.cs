using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    /// <summary>
    /// Прогрманое обеспечение
    /// </summary>
     abstract class Software
     {
        public string Name { get; set; }
        public string Manufacturer { get; set; }

        public Software(string name, string manufacturer)
        {
            Name = name;
            Manufacturer = manufacturer;
        }

        public abstract void DisplayInfo();
        public abstract string CheckUsage();

    }
}
