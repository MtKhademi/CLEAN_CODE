using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_IteratorPattern._02Try
{
    internal interface ITerator<T>
    {
        void Push(T item);
        T Pop();
    }
}
