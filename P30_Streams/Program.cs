namespace P30_Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var smalsumas = new Smalsumas();
            smalsumas.OptimizacijosUzdavinys("data.txt", 50_000);
        }
    }
}
