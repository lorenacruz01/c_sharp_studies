using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace InterfaceApp3.Model.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            double area = Radius * Radius * Math.PI;
            return area;
        }

        public override string ToString()
        {
            return "Circle color: " + Color
                + ", radius: " + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", area: " + Area().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
