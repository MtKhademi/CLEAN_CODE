using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_IteratorPattern._02Try.Eterators
{
    internal class ListEterator : ITerator<string>
    {
        private List<string> _items = new List<string>();

        public string Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(string item)
        {
            throw new NotImplementedException();
        }
    }
}
