
//using _01_Encapulation.Bad;

//var acc = new Account();
//acc.Balance = 10; // START

////-- Diposit => 100
//acc.Balance += 100;

////-- Withdraw 200
////-- logic checking ...
//acc.Balance -= 200;

//Console.WriteLine(acc);


using _01_Encapulation.Good;

var acc = new Account(-10);
acc.Diposit(100);
// update db

acc.WithDraw(50);
// update db

Console.WriteLine(acc.ToString());  

