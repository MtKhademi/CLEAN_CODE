using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ObserverPattern._02Try
{
    internal class Chart : Ibserver
    {
        public Chart(IObservable observable)
        {
            observable.AddNewObserver(this);
        }
        public void Notify(List<int> items)
        {
            Console.WriteLine($"NEW RENDER CHART : [{string.Join('|', items)}]");
        }
    }
}
