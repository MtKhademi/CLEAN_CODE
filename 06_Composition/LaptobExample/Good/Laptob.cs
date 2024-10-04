using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Composition.LaptobExample.Good
{
    internal class Laptob
    {
        //HAS-A

        public List<Ram> Rams { get; set; }
        public Keyboard KeyBoard { get; set; }

        public Power Power { get; set; }


        public decimal GetPrice()
        {
            return Rams.Sum(x => x.Price) + KeyBoard.Price + Power.Price;
        }

    }
}
