using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TemplateMethodPattern._03Try
{
    internal class DrinkMaker
    {
        private readonly IDrink _drink;

        public DrinkMaker(IDrink drink)
        {
            _drink = drink;
        }

        public void Prepare() => _drink.Prepare();
    }
}
