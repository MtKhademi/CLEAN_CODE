using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _07_ObserverPattern._01Try
{
    internal class Calculation : IReload
    {
        public void Render(List<int> items)
        {
            Console.WriteLine($"NEW RENDER CALCUALTION : sum : {items.Sum()} - [{string.Join('|', items)}]");
        }
    }
}
