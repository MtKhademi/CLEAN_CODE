using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TemplateMethodPattern._04Try
{
    internal class Cofee : Drink
    {
        protected override void Brew() => Console.WriteLine("Brew cofee for 1 minutes");
        protected override void AskCustomer()
        {
            Console.WriteLine("Do you want some suger ? (Y/N)");
            var response = Console.ReadLine();
            if (response.ToLower() == "y")
            {
                Console.WriteLine("Puring some suger in cofee");
            }
        }
    }
}
