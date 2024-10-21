using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TemplateMethodPattern._02Try
{
    internal class Cofee
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
        private void Brew() => Console.WriteLine("Brew cofee for 1 minutes");
        private void AskCustomer()
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
