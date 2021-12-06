using InterfaceApp3.Model.Entities;
using InterfaceApp3.Model.Enums;
using System;

namespace InterfaceApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.0, Color = Color.Black};
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
