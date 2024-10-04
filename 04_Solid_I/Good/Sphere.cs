using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Solid_I.Good
{
    internal class Sphere : IShape2D, IShape3D
    {
        public double Area() => 19.90;

        public double Volume() => 1234;
    }
}
