using System;

namespace Program
{
    class objetos
    {
        static void Main(string[] args)
        {
            Product mouse = new Product(1, "Mouse Gamer", 299.37, EproductType.product);
            var manuetencaoEletrica = new Product(2, "Manutenção elétrica residencial", 500, EproductType.product);

            mouse.Id = 10;
            mouse.Price = 10;

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine((int)mouse.Type); // Conversão explícita
            double priceInDollar = mouse.PriceInDollar();
            Console.WriteLine($"{priceInDollar}");

        }
    }

    struct Product // Type value
    {
        public Product(int id, string name, double price, EproductType type) // Construtor
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public int Id;
        public string Name;
        public double Price;
        public EproductType Type;

        public double PriceInDollar(double dolar = 10)
        {
            return Price * dolar;
        }
    }

    enum EproductType
    {
        product = 1, 
        service = 2,
    }

}