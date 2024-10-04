namespace _03_Solid_I.Bad
{
    internal class Rectangle : Shape
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }

        public override void Area()
        {
            Console.WriteLine($"Rectangle ==> {Width}*{Height}={Width * Height}");
        }
    }
}
