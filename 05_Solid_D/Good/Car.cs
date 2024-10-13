using _05_Solid_D.Good.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Solid_D.Good
{
    internal class Car
    {
        public IEngine Engine { get; set; }

        public Car(IEngine engine)
        {
            Engine = engine;
        }
    }
}
