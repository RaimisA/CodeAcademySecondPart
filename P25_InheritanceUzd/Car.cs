namespace P25_InheritanceUzd
{
    public class Car : Transport
    {
        public Car(int speed) : base()
        {
            Speed = speed;
        }
        public int Speed { get; set; }
        public override double MeasureSpeed()
        {
            return Speed;
        }
    }

}
