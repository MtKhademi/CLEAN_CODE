using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Coupling.OrderEample.Bad
{
    internal class Order
    {
        public void SetOrder()
        {
            // LOGIN
            // DB
            //......

            //SendEmail sender = new SendEmail();
            SmsSender sender = new SmsSender();
            sender.Send("Order is success");
        }
    }
}
