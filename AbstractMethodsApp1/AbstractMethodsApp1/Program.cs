using AbstractMethodsApp1.Entities;
using AbstractMethodsApp1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AbstractMethodsApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"-------Shape #{i} data--------");
                Console.Write("Rectangle or Circle (r/c) ? ");
                char shape = char.Parse(Console.ReadLine());
                Console.Write("Color (Black, Red, Blue): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (shape == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(color, width, height));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(color, radius));
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("----------SHAPE AREAS----------");
            foreach (Shape obj in list)
            {
                Console.WriteLine("Area: " + obj.Area().ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}
