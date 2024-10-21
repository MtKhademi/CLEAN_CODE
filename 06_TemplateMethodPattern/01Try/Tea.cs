using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TemplateMethodPattern._01Try
{
    internal class Tea
    {
        public void BoilingWater() => Console.WriteLine("Boiling water");
        public void PurIntoCup() => Console.WriteLine($"Puring water into cup");
        public void Brew() => Console.WriteLine("Brew tea for 3 minutes");
        public void AskCustomer()
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
