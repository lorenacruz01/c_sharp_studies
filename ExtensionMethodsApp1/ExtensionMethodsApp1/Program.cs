using ExtensionMethodsApp1.Extensions;
using System;

namespace ExtensionMethodsApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 12, 01, 13, 3, 0);
            Console.WriteLine(dt.ElapsedTime());
            string s1 = "Good morning, dear students";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
