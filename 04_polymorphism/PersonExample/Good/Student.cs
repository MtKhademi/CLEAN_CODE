using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_polymorphism.PersonExample.Good
{
    internal class Student : Person
    {
        public decimal Degree { get; set; }


        public override string LoginChange()=> $"[Stuedent] {Name} is login";

    }
}
