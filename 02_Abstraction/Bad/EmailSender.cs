using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Abstraction.Bad
{
    internal class EmailSender
    {
        public void Connect() => Console.WriteLine("Connected");
        public void Authenticate() => Console.WriteLine("Authenticated");
        public void SendEmail(string email, string message) => Console.WriteLine($"Send a new email to {email} : {message}");
        public void Disconnec() => Console.WriteLine("Disconnected");
    }
}
