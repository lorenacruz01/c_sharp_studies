using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritanceApp1.Entities
{
    class Printer : Device
    {
        public override void ProcessDocument(string doc)
        {
            Console.WriteLine("Printer processing: " + doc);
        }
        public void Print()
        {
            Console.WriteLine("Printer result ");
        }
    }
}
