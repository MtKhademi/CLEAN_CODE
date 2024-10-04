
//O => Open/Close principle


//using _02_Solid_O.Bad;

//Shape shape = new Shape();
//shape.ShapeType = ShapeType.Cricle;
//shape.Radius = 5;
//shape.Area();

using _02_Solid_O.Good;

Shape s = new Circle() { Radius = 10 };
s.Area();

s = new Rectangle() { Width = 10, Height = 10 };
s.Area();
