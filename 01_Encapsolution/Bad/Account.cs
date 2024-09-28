using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Encapulation.Bad
{
    internal class Account
    {
        public double Balance { get; set; }

        public override string ToString() => $"Balance is {Balance}";
    }
}
