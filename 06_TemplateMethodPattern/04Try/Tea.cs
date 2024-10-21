using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TemplateMethodPattern._04Try
{
    // Abstraction
    internal class Tea : Drink
    {
        protected override void Brew() => Console.WriteLine("Brew tea for 3 minutes");

        protected override void AskCustomer()
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
