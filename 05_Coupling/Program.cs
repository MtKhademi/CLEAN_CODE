

using _05_Coupling.OrderEample.Good;

var orderService = new OrderService(new SendEmail());
orderService.SetOrder();


var orderService1 = new OrderService(new SendSms());
orderService1.SetOrder();