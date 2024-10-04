using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Solid_O.Bad
{

    enum ShapeType
    {
        Cricle,
        Rectangle
    }

    internal class Shape
    {
        public ShapeType ShapeType { get; set; }
        public double Radius { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        //-> PROPERTI

        public void Area()
        {
            switch (ShapeType)
            {
                case ShapeType.Cricle:
                    Console.WriteLine($"{nameof(ShapeType)} ==> {Math.PI * Math.Pow(Radius, 2)}");
                    break;
                case ShapeType.Rectangle:
                    Console.WriteLine($"{nameof(ShapeType)} ==> {Width * Height}");
                    break;
                default:
                    Console.WriteLine("NOT RECOGNIZE");
                    break;
            }
        }
    }
}
