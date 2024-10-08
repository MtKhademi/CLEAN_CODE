﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Inheritance.VehicleExample.Good
{
    internal abstract class Vehicle
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public int Wheels { get; set; }

        public abstract void Start();
        public abstract void Stop();
    }
}
