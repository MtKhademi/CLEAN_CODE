using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_IteratorPattern._01Try
{
    internal class ShoopingList
    {
        private List<string> _items = new List<string>();
        //private string[] _items = new string[100];
        

        public void Push(string  item)=>_items.Add(item);
        public string Pop()
        {
            var item = _items.Last();
            _items.Remove(item);
            return item;
        }

        public void ShowItems()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }

    }
}
