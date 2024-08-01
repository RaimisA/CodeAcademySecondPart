namespace P25_InheritanceUzd
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine($"Piesiam apskritima, kai spindulys yra : {Radius}"); ;
        }
    }
}
