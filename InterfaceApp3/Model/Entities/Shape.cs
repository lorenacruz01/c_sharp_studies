using InterfaceApp3.Model.Enums;

namespace InterfaceApp3.Model.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
