using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Inheritance.VehicleExample.Bad
{
    internal class Bike
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public int Wheels { get; set; }

        public void Start() => Console.WriteLine("Bike started ...");
        public void Stop() => Console.WriteLine("Bike stoped ...");
    }
}
