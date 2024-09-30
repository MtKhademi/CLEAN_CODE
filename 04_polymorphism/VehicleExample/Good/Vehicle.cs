using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_polymorphism.VehicleExample.Good
{
    internal abstract class Vehicle
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public abstract void Start();
    }
}
