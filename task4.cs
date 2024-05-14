namespace task4
{
    public interface ISwimmable
    {
        void Swim()
        {
            Console.WriteLine("I can swim!");
        }
    }

    public interface IFlyable
    {
        int MaxHeight => 0;

        void Fly()
        {
            Console.WriteLine($"I can fly at {MaxHeight} meters height!");
        }
    }

    public interface IRunnable
    {
        int MaxSpeed => 0;
        void Run()
        {
            Console.WriteLine($"I can run up to {MaxSpeed} kilometers per hour!");
        }
    }

    public interface IAnimal
    {
        int LifeDuration => 0;
        void Voice()
        {
            Console.WriteLine("No voice!");
        }

        void ShowInfo()
        {
            Console.WriteLine($"I am a {this.GetType().Name} and I live {LifeDuration} years.");
        }
    }

    public class Cat : IAnimal, IRunnable
    {
        public int LifeDuration { get; } = 9;
        public int MaxSpeed { get; } = 20;

        public void Voice()
        {
            Console.WriteLine("Meow!");
        }
    }

    public class Eagle : IAnimal, IFlyable
    {
        public int LifeDuration { get; } = 17;
        public int MaxHeight { get; } = 1000;

        public void Voice()
        {
            Console.WriteLine("Reeeeeeeeee!");
        }
    }

    public class Shark : IAnimal, ISwimmable
    {
        public int LifeDuration { get; } = 25;
    }


    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product { Name = "SmartTV", Price = 400, Category = "Electronics" },
                new Product { Name = "Lenovo ThinkPad", Price = 1000, Category = "Electronics" },
                new Product { Name = "Iphone", Price = 700, Category = "Electronics" },
                new Product { Name = "Orange", Price = 2, Category = "Fruits" },
                new Product { Name = "Banana", Price = 3, Category = "Fruits" }
            };
            ILookup<string, Product> lookup = products.ToLookup(prod => prod.Category);
            TotalPrice(lookup);
            Console.ReadKey();
        }

        static void TotalPrice(ILookup<string, Product> lookup)
        {
            foreach (var group in lookup)
            {
                double totalPriceForCategory = group.Sum(product => product.Price);
                Console.WriteLine($"{group.Key} Total Price: {totalPriceForCategory}");

                foreach (var product in group)
                {
                    Console.WriteLine($"{product.Name} {product.Price}");
                }
            }
        }
    }
}
