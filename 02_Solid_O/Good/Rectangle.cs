namespace _02_Solid_O.Good
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override void Area()
        {
            Console.WriteLine($"Rectangle ==> {Width * Height}");
        }
    }
}
