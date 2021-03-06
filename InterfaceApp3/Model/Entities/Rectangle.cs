using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace InterfaceApp3.Model.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            double area = Width * Height;
            return area;
        }

        public override string ToString()
        {
            return "Rectangle color: " + Color
                + ", width: " + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", height: " + Height.ToString("F2", CultureInfo.InvariantCulture)
                + ", area: " + Area().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
