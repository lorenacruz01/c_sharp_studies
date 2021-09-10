using System;
using System.Globalization;

namespace ArrayApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;
            Product[] v = new Product[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome do produto " + (i+1) + ": ");
                string name = Console.ReadLine();
                Console.Write("Digite o preço do produto " + (i+1) + ": ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                v[i] = new Product{ Name = name, Price = price };

                sum += v[i].Price;
            }
            double avg = sum / n;
            Console.Write("A média dos preços dos produtos é: ");
            Console.WriteLine(avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
