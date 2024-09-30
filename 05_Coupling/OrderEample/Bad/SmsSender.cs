using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Coupling.OrderEample.Bad
{
    internal class SmsSender
    {
        public void Send(string message) => Console.WriteLine($"SMS SEND : {message}");
    }
}
