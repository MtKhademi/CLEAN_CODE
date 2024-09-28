using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Abstraction.Good
{
    internal class EmailSender
    {
        private void Connect() => Console.WriteLine("Connected");
        private void Authenticate() => Console.WriteLine("Authenticated");
        public void SendEmail(string email, string message)
        {
            Connect();
            Authenticate();
            Console.WriteLine($"Send a new email to {email} : {message}");
            Disconnec();
        }
        private void Disconnec() => Console.WriteLine("Disconnected");
    }
}
