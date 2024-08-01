namespace P31_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintInfo<int>(11);
            PrintInfo<double>(11.5);
            PrintInfo<string>("tekstas");

            var genericClass = new GenericClass<string>();

            genericClass.Set("tekstas");
            var val = genericClass.Get();

            var repoTomato = new Repository<Tomato>();
            
            repoTomato.Add(new Tomato());
            repoTomato.Add(new Tomato());
            repoTomato.Add(new Tomato());
            repoTomato.Add(new Tomato());

            var repoCarrot = new Repository<Carrot>();

            repoCarrot.Add(new Carrot());

            Console.WriteLine(repoCarrot.GetByIndex(0));

            
        }

        public static void PrintInfo<T>(T obj) 
        {
            Console.WriteLine(obj.GetType().Name + ": " + obj);
        }
    }
}
