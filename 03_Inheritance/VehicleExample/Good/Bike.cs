using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Inheritance.VehicleExample.Good
{
    internal class Bike : Vehicle
    {
        public override void Start() => Console.WriteLine("Bike started ...");
        public override void Stop() => Console.WriteLine("Bike stoped ...");
    }
}
