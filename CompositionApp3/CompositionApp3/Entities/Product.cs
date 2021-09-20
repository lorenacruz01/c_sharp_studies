using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace CompositionApp3.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

       /* public override string ToString()
        {
            return "Product=  name: " + Name + ", price: " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }*/
    }
}
