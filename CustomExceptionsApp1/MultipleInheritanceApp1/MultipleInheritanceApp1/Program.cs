using MultipleInheritanceApp1.Entities;
using System;

namespace MultipleInheritanceApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDocument("My letter");
            p.Print();

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDocument("My test");
            Console.WriteLine(s.Scan());
        }
    }
}
