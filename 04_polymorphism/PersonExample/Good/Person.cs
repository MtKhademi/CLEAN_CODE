using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_polymorphism.PersonExample.Good
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }

        public abstract string LoginChange();

    }
}
