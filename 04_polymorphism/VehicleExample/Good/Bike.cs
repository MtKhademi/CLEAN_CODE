using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_polymorphism.VehicleExample.Good
{
    internal class Bike : Vehicle
    {
        public override void Start() => Console.WriteLine($"BIKE[{Name}] is started ...");
    }
}
