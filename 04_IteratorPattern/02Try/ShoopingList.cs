using _04_IteratorPattern._02Try.Eterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_IteratorPattern._02Try
{
    internal class ShoopingList
    {
        //private string[] _items = new string[100];
        private ITerator<string> _list;
        public ShoopingList()
        {
            //_list = new ListEterator();
            _list = new ArrayEterator();
        }

        public void Push(string item) => _list.Push(item);
        public string Pop() => _list.Pop();

        public void ShowItems()
        {
            //foreach (var item in _list.Pop())
            //{
            //    Console.WriteLine(item);
            //}
        }

    }
}
