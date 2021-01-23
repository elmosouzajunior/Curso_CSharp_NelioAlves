using System.Globalization;
using System;

namespace Secao10_Product.Entities
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

        public virtual void PriceTag()
        {
            Console.WriteLine("Name: " 
                + Name
                +" $ " 
                + Price.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
