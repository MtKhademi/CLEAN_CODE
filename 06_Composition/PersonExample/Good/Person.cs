using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Composition.PersonExample.Good
{
    internal class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }


        public List<Phone> Phones { get; set; }

        public Address Address { get; set; }

    }
}
