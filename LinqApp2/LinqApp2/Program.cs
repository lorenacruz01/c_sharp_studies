using System;
using System.Linq;
using System.Collections.Generic;
using LinqApp2.Entities;
using System.Globalization;

namespace LinqApp2
{
    internal class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach(T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.00, Category = c2},
                new Product() { Id = 2, Name = "Hammer", Price = 90.00, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.00, Category = c3},
                new Product() { Id = 4, Name = "Notebook", Price = 1300.00, Category = c2},
                new Product() { Id = 5, Name = "Saw", Price = 80.00, Category = c1},
                new Product() { Id = 6, Name = "Tablet", Price = 700.00, Category = c2},
                new Product() { Id = 7, Name = "Camera", Price = 700.00, Category = c3},
                new Product() { Id = 8, Name = "Printer", Price = 350.00, Category = c3},
                new Product() { Id = 9, Name = "Macbook", Price = 1800.00, Category = c2},
                new Product() { Id = 10, Name = "Sound bar", Price = 700.00, Category = c3},
                new Product() { Id = 11, Name = "Level", Price = 70.00, Category = c1}

            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            Print("TIER 1 AND PRICE < 900: ", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAME OF ALL PRODUCTS FROM TOOLS: ", r2);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, Category = p.Category.Name });
            Print("NAMES STARTING WITH C: ", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            var r6 = products.FirstOrDefault();
            Console.WriteLine("First or default test1: " + r6);
            var r7 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r7);

            Console.WriteLine();
            var r8 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r8.ToString("F2", CultureInfo.InvariantCulture));
            var r9 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r9.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            var r10 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 summed prices: " + r10.ToString("F2", CultureInfo.InvariantCulture));
            var r11 = products.Where(p => p.Category.Id == 3).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 1 average price: " + r11.ToString("F2", CultureInfo.InvariantCulture));
            var r12 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: " + r12.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            var r13 = products.GroupBy(p => p.Category);
            foreach(IGrouping<Category, Product> group in r13)
            {
                Console.WriteLine("Category: " + group.Key.Name + ": ");
                foreach(Product product in group)
                {
                    Console.WriteLine(product);
                }
                Console.WriteLine();
            }

        }
    }
}
