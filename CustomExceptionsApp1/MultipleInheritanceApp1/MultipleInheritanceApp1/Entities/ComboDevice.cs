using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritanceApp1.Entities
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string doc)
        {
            Console.WriteLine("ComboDevice print: " + doc);
        }

        public override void ProcessDocument(string doc)
        {
            Console.WriteLine("ComboDevice processing " + doc);
        }

        public string Scan()
        {
            return "Combodevice scan result";
        }
    }
}
