using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ObserverPattern._02Try
{
    internal class DataSource : IObservable
    {
        private List<int> _items = new List<int>();
        private List<Ibserver> _observs = new List<Ibserver>();

        public void AddNewObserver(Ibserver obser) => _observs.Add(obser);

        public List<int> Items => _items;

        public void Change(List<int> newItems)
        {
            _items = newItems;
            _observs.ForEach(x => x.Notify(_items));
        }

        public void Update(List<int> newItems)
        {
            _items = [.. _items, .. newItems];
            _observs.ForEach(x => x.Notify(_items));
        }

    }
}
