using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Solid_I.Bad
{
    internal class Cricle : IShape
    {
        public double Area() => 10;

        public double Volume()
        {
            throw new NotImplementedException("Circle can not be implemented this");
        }
    }
}
