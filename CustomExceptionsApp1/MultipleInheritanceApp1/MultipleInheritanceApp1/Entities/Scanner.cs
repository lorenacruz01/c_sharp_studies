using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritanceApp1.Entities
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDocument(string doc)
        {
            Console.WriteLine("Scanner processing: " + doc);
        }
        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
