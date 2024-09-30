using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_polymorphism.PersonExample.Good
{
    internal class Teacher : Person
    {
        public int Works { get; set; } // مقدار سال سابقه اس

        public override string LoginChange() => $"[Teacher] {Name} is login";

    }
}
