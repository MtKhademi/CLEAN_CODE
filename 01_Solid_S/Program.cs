

////-> Single resposiblity
//using _01_Solid_S.Bad;
//using _01_Solid_S.Good;

//User u = new User();
//u.Name = "MrKhademi";
//u.Register();

using _01_Solid_S.Good;

var u = new User();
u.Name = "Mr khademi";
var userService = new UserService();
userService.Register(u);