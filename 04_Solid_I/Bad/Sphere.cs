using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Solid_I.Bad
{
    internal class Sphere : IShape
    {
        public double Area() => 19.90;

        public double Volume() => 1234;
    }
}
