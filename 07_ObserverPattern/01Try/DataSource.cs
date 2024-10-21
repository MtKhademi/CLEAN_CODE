using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ObserverPattern._01Try
{
    internal class DataSource
    {
        private List<int> _items = new List<int>();

        public List<int> Items => _items;

        public void Change(List<int> newItems) => _items = newItems;

    }
}
