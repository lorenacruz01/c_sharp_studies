using AbstractMethodsApp1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractMethodsApp1.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
   

        public Shape(Color color)
        {
            Color = color;
        }

        //abstract method
        public abstract double Area();

    }
}
