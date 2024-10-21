using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TemplateMethodPattern._03Try
{
    // Abstraction
    internal class Tea : IDrink
    {
        
        private void BoilingWater() => Console.WriteLine("Boiling water");
        private void PurIntoCup() => Console.WriteLine($"Puring water into cup");
        private void Brew() => Console.WriteLine("Brew tea for 3 minutes");
        private void AskCustomer()
        {
            Console.WriteLine("Do you want some lemon ? (Y/N)");
            var response = Console.ReadLine();
            if (response.ToLower() == "y")
            {
                Console.WriteLine("Puring some lemon in tea");
            }
        }

        public void Prepare()
        {
            BoilingWater();
            PurIntoCup();
            Brew();
            AskCustomer();
        }
    }
}
