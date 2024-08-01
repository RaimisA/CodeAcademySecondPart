namespace OOPFirstUzd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Tomas", 28, 180);
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Height: {person.Height}");

            School school = new School("VU", "Vilnius", 200);
            Console.WriteLine($"Name: {school.Name}, City: {school.City}, Pupils: {school.Pupil}");

            Book book = new Book("A Song of Ice and Fire", "George R. R. Martin", 1996, "USA");
            Console.WriteLine($"Name: {book.Name}, Author: {book.Author}, Year: {book.Year}, Country: {book.Country}");

            List<Book> books = new List<Book>
            {
                new Book("A Song of Ice and Fire", "George R. R. Martin", 1996, "USA"),
                new Book("The Hobbit", "J.R.R. Tolkien", 1937, "UK"),
                new Book("A Clash of Kings", "George R. R. Martin", 1998, "USA")
            };

            string author = "George R. R. Martin";
            List<Book> filteredBooks = FilterByAuthor(author, books);
            Console.WriteLine($"Books by {author}:");
            foreach (Book book1 in filteredBooks)
            {
                Console.WriteLine(book1.Name);
            }

            Store store1 = new Store("Maxima", 1999);
            store1.ProductName.Add("Duona");
            store1.ProductName.Add("Pienas");
            store1.ProductName.Add("Sviestas");

            Store store2 = new Store("Topo Centras", 2005);
            store2.ProductName.Add("LG Oled 77\" Tv" );
            store2.ProductName.Add("Samsung fridge");
            store2.ProductName.Add("AEG washer-dryer");

            List<Store> stores = new List<Store> { store1, store2 };

            foreach (var store in stores)
            {
                foreach (var product in store.ProductName)
                {
                    Console.WriteLine($"{store.Name} {store.Date} - {product}");
                }
            }

            List<Dog> dog = new List<Dog>
            {
                new Dog("Rex"),
                new Dog("Buddy"),
                new Dog("Fido"),
                new Dog("Spot"),
                new Dog("Max"),
                new Dog("Charlie"),
                new Dog("Cooper"),
                new Dog("Milo"),
            };
            List<Cat> cat = new List<Cat>
            {
                new Cat("Miau"),
                new Cat("Whiskers"),
                new Cat("Salem"),
                new Cat("Garfield"),
                new Cat("Simba"),
                new Cat("Luna"),
                new Cat("Bella"),
                new Cat("Tiger"),
            };
            List<Hamster> hamster = new List<Hamster>
            {
                new Hamster("Burbulis"),
                new Hamster("Nibbles"),
                new Hamster("Gizmo"),
                new Hamster("Hammy"),
                new Hamster("Pip"),
                new Hamster("Zorro"),
                new Hamster("Fuzzy"),
                new Hamster("Squeak")
            };

            var petNames = GetClassNames(dog, cat, hamster);
            
            foreach (var name in petNames)
            {
                Console.WriteLine($"Pet name: {name}");
            }

            var petCount = GetAnimalTypeCounts(dog, cat, hamster);

            foreach (var count in petCount)
            {
                Console.WriteLine($"Pet count: {count}");
            }

            Circle circle = new Circle(5);
            Console.WriteLine($"Circle area: {circle.GetArea()}");
            Console.WriteLine($"Circle perimeter: {circle.GetPerimeter()}");

            Square square = new Square(5);
            Console.WriteLine($"Square area: {square.GetArea()}");
            Console.WriteLine($"Square perimeter: {square.GetPerimeter()}");

            Triangle trianglePerimeter = new Triangle(3, 4, 5);
            Console.WriteLine($"Triangle perimeter: {trianglePerimeter.GetPerimeter()}");

            Triangle triangleArea = new Triangle(3, 4);
            Console.WriteLine($"Triangle area: {triangleArea.GetArea()}");

            Car car = new Car();
            StartEngineAndDisplayStatus(car);
        }

        public static List<Book> FilterByAuthor(string author, List<Book> books)
        {
            List<Book> filteredBooks = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Author == author)
                {
                    filteredBooks.Add(book);
                }
            }
            return filteredBooks;
        }

        public static List<string> GetClassNames(List<Dog> dogs, List<Cat> cats, List<Hamster> hamsters)
        {
            List<string> classNames = new List<string>();

            foreach (var dog in dogs)
            {
                classNames.Add(dog.Name);
            }

            foreach (var cat in cats)
            {
                classNames.Add(cat.Name);
            }

            foreach (var hamster in hamsters)
            {
                classNames.Add(hamster.Name);
            }

            return classNames;
        }
        public static Dictionary<string, int> GetAnimalTypeCounts(List<Dog> dog, List<Cat> cat, List<Hamster> hamster)
            {
            Dictionary<string, int> typeCounts = new Dictionary<string, int>();
            typeCounts.Add("Dogs", dog.Count());
            typeCounts.Add("Cats", cat.Count());
            typeCounts.Add("Hamsters", hamster.Count());
            return typeCounts;
        }
        public static void StartEngineAndDisplayStatus(Car car)
        {
            car.StartEngine();
            Console.WriteLine($"The car's engine is {(car.Engine.IsOn ? "on" : "off")}");
        }

    }
}
