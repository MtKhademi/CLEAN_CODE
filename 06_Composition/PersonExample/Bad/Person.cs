using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Composition.PersonExample.Bad
{
    internal class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }



        public string FixPhone { get; set; }
        public string SelfPhone { get; set; } 
        public string ParrentPhone { get; set; }



        public string City { get; set; }
        public string State { get; set; }
        public string DEtailsAddress { get; set; }
        public string zipCode { get; set; }
    }
}
