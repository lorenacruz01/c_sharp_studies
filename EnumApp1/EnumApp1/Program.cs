using System;
using EnumApp1.Entities;
using EnumApp1.Entities.Enums;

namespace EnumApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string str = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(str);
            Console.WriteLine(os);
        }
    }
}
