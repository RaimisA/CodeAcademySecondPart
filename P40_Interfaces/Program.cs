namespace P40_Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            IMyLogger logger = new FileMyLogger("log.txt");
            logger.Log("Program started");
            OrderService orderService = new OrderService(logger);
            orderService.PlaceOrder();
            var loggers = new List<IMyLogger>
            {
                new ConsoleMyLogger(),
                new FileMyLogger("log.txt")
            };
        }
    }
}
