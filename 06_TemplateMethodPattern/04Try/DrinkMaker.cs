using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TemplateMethodPattern._04Try
{
    internal class DrinkMaker
    {
        private readonly Drink _drink;

        public DrinkMaker(Drink drink)
        {
            _drink = drink;
        }

        public void Prepare() => _drink.Prepare();
    }
}
