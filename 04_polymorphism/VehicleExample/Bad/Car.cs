using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_polymorphism.VehicleExample.Bad
{
    internal class Car
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int NumberOfDoors { get; set; }

        public void Start() => Console.WriteLine($"Car[{Name}] is started ...");
    }
}
