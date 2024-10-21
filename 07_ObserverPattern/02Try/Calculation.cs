using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _07_ObserverPattern._02Try
{
    internal class Calculation : Ibserver
    {
        public Calculation(IObservable observable)
        {
            observable.AddNewObserver(this);
        }
        public void Notify(List<int> items)
        {
            Console.WriteLine($"NEW RENDER CALCUALTION : sum : {items.Sum()} - [{string.Join('|', items)}]");
        }
    }
}
