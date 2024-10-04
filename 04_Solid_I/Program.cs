
// i => Interface segregation principle (ISP)

//using _04_Solid_I.Bad;
//using _04_Solid_I.Good;

//Cricle cricle = new Cricle();
//cricle.Area();


using _04_Solid_I.Bad;


Cricle c = new Cricle();
Calculate(c);

static void Calculate(IShape shape)
{
    shape.Volume();
}