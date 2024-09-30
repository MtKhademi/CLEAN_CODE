
//// polymorphism => Poly , Morphism
//// Poly = Many
//// Morphism => Form

////-------------

//using _04_polymorphism.VehicleExample.Good;

////List<Car> cars =
////    [
////        new Car{ Name = "Pride", Brand ="Khiar",NumberOfDoors = 4},
////        new Car{ Name = "BMW", Brand ="XX3",NumberOfDoors = 2}
////    ];

////foreach (var item in cars)
////{
////    item.Start();
////}

////List<Bike> bikes =
////    [
////        new Bike{ Name = "Pride", Brand ="Khiar"},
////        new Bike{ Name = "BMW", Brand ="XX3"}
////    ];

////foreach (var item in bikes)
////{
////    item.Start();
////}


//List<Vehicle> vehicles =
//    [
//        new Car{ Name = "Pride", Brand ="Khiar",NumberOfDoors = 4},
//        new Car{ Name = "BMW", Brand ="XX3",NumberOfDoors = 2},
//        new Bike{ Name = "NINJA", Brand ="XX3"},
//    ];
//foreach (var item in vehicles)
//{
//    item.Start();
//}



using _04_polymorphism.PersonExample.Good;

Student st = new Student { Name = "ALI" };
Teacher te = new Teacher { Name = " HAVIJ" };

PersonService service = new PersonService();
service.Login(st);
service.Login(te);


