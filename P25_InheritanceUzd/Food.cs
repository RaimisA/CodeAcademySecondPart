namespace P25_InheritanceUzd
{
    public class Food : Product
    {
        public Food(string name, double price) : base(name, price)
        {
            ExpirationTime = DateTime.Now.AddDays(7);
        }
        public DateTime ExpirationTime { get; set; }
    }
}
