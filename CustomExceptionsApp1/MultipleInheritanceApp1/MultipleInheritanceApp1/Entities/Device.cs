using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritanceApp1.Entities
{
    abstract class Device
    {
        public int SerialNumber { get; set; }
        public abstract void ProcessDocument(string doc);
    }
}
