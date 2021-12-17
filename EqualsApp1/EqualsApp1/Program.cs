using System;

namespace EqualsApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Alex";
            string b = "Maria";
            string c = "Maria";
            Console.WriteLine("A and B => Equal?");
            Console.WriteLine(a.Equals(b));
            Console.WriteLine("B and C => Equal?");
            Console.WriteLine(b.Equals(c));

        }
    }
}
