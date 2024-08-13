using System;
using Exercicio.Entities;
using System.Globalization;



namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter cliente data:");
            Console.Write("Name:");
            string ClientName = Console.ReadLine();
            Console.Write("Email:");
            string ClientEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY):");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data:");
            Console.Write("Status:");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(ClientName, ClientEmail, birthDate);
            Order order = new Order(DateTime.Now, status, client);


            Console.Write("How many items this order:");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine($" Enter #{i} item data");
                Console.Write("Product name:");
                string productName = Console.ReadLine();
                Console.Write("Product price:");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.Write("Quantity:");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(product, quantity, price);

                order.AddItem(orderItem); 




            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMARY:");
            Console.WriteLine(order); 
        } 
    }
}
