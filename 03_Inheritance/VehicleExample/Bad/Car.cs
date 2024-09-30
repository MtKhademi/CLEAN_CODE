using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Inheritance.VehicleExample.Bad
{
    internal class Car
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public int Wheels { get; set; }
        public int NumberOfDoors { get; set; }

        public void Start() => Console.WriteLine("Car started ...");
        public void Stop() => Console.WriteLine("Car stoped ...");
    }
}
