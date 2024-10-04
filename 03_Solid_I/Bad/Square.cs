using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Solid_I.Bad
{
    internal class Square : Shape
    {
        public double SideSize { get; set; }

        public override void Area() => Console.WriteLine(SideSize * SideSize);
    }
}
