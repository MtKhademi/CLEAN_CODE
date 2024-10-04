using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Solid_I.Good
{
    internal interface IShape2D
    {
        double Area();
    }

    internal interface IShape3D
    {
        double Volume();
    }
}
