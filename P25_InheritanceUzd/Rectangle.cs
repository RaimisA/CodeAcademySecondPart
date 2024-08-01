namespace P25_InheritanceUzd
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override void Draw()
        {
            Console.WriteLine($"Piesiam staciakampi, kai jo plotis: {Width}, o aukstis: {Height}"); ;
        }
    }
}
