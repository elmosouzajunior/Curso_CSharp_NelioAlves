using System;
using System.Globalization;
using Secao10_Product.Entities;
using System.Collections.Generic;

namespace Secao10_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listOfProducts = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 1; i <= numberOfProducts; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, Used or Imported (c/u/i)? ");
                char typeProduct = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (typeProduct == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/AAAA): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    listOfProducts.Add(new UsedProduct(name, price, date));
                }
                else if(typeProduct == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listOfProducts.Add(new ImportedProduct(name, price, customsFee));
                }
                else
                {
                    listOfProducts.Add(new Product(name, price));
                }
                Console.WriteLine();
            }

            Console.WriteLine("PRICE TAGS:");
            foreach(Product prod in listOfProducts)
            {
                prod.PriceTag();
            }
        }
    }
}
