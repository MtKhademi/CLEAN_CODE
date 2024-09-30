using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Inheritance.VehicleExample.Good
{
    internal class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public override void Start() => Console.WriteLine("Car started ...");
        public override void Stop() => Console.WriteLine("Car stoped ...");
    }
}
