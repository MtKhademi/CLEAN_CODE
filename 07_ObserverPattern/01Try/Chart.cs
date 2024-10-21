using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ObserverPattern._01Try
{
    internal class Chart : IReload
    {
        public void Render(List<int> items)
        {
            Console.WriteLine($"NEW RENDER CHART : [{string.Join('|', items)}]");
        }
    }
}
