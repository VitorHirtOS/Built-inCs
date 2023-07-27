using System;

namespace Program
{
    class objetos
    {
        static void Main(string[] args)
        {
            Product mouse = new Product(1, "Mouse Gamer", 299.37);

            mouse.Id = 10;

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
        }
    }

    struct Product // Type value
    {
        public Product(int id, string name, double price) // Construtor
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id; 
        public string Name;
        public double Price;

        public double PriceInDollar(double dolar)
        {
            return Price * dolar;
        }
    }

}