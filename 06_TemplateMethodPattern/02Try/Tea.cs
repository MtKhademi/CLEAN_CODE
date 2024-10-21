using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TemplateMethodPattern._02Try
{
    // Abstraction
    internal class Tea
    {
        public void Make()
        {
            BoilingWater();
            PurIntoCup();
            Brew();
            AskCustomer();
        }
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
    }
}
