using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Coupling.OrderEample.Good
{
    internal class SendEmail : INotification
    {
        public void Send(string message) => Console.WriteLine($"SEND EMAIL : {message}");
    }
}
