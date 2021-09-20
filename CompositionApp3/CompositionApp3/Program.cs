using System;
using System.Globalization;
using CompositionApp3.Entities;
using CompositionApp3.Entities.Enums;

namespace CompositionApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (dd/mm/yyyy): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("----------------------");
            Console.WriteLine("Enter order data");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine("How many items?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");

            Client client = new Client(clientName, email, birthdate);
            Order order = new Order(DateTime.Now, status, client);

            for(int i=1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
