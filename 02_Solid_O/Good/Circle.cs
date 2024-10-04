namespace _02_Solid_O.Good
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }
        public override void Area()
        {
            Console.WriteLine($"Cricle ==> {Math.PI * Math.Pow(Radius, 2)}");
        }
    }
}
