using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Coupling.OrderEample.Good
{
    internal class OrderService
    {
        private readonly INotification sender;
        public OrderService(INotification sender)
        {
            this.sender = sender;
        }
        public void SetOrder()
        {
            var order = new Order();
            order.SetOrder();

            //NOTif
            sender.Send("Order is success");
        }
    }
}
