
//-- IS-A

using _03_Inheritance.VehicleExample.Good;

Car car = new Car();
car.Name = "Pride";
car.Year = 1200;
car.Model = "141";

car.Start();
car.Stop();


Bike bike = new Bike();
bike.Name = "Pride";
bike.Year = 1200;
bike.Model = "141";

bike.Start();
bike.Stop();


Vehicle v1 = car; //IS-A
Vehicle v2 = bike;