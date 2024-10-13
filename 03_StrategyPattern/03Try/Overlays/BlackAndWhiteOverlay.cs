using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_StrategyPattern._03Try.Overlays
{
    internal class BlackAndWhiteOverlay : IOverlay
    {
        public void Overlay(string file)
        {
            Console.WriteLine($"Overlay {file} with BlackAndWhite algorithm");
        }
    }
}
