using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TemplateMethodPattern._04Try
{
    internal abstract class Drink
    {
        public void Prepare()
        {
            BoilingWater();
            PurIntoCup();

            // HOOK
            Brew();
            AskCustomer();
        }
        private void BoilingWater() => Console.WriteLine("Boiling water");
        private void PurIntoCup() => Console.WriteLine($"Puring water into cup");
        protected abstract void Brew();
        protected abstract void AskCustomer();

    }
}
