using System;
using System.Collections.Generic;
using Secao10_Shapes.Entities.Enums;
using Secao10_Shapes.Entities;
using System.Globalization;

namespace Secao10_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shapes> listOfShapes = new List<Shapes>();
            
            Console.Write("Enter the number of shapes: ");
            int numberOfShapes = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 1; i <= numberOfShapes; i++)
            {
                Console.WriteLine($"Shape #{i} data:");                
                Console.Write("Rectangle or Circle (r/c)? ");
                char typeOfShape = char.Parse(Console.ReadLine());
                Console.Write("Color: (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (typeOfShape == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listOfShapes.Add(new Circle(color, radius));
                }
                else if (typeOfShape == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listOfShapes.Add(new Rectangle(color, width, height));
                }
                else
                {
                    Console.WriteLine("Incorrect shape!!!");
                }
                Console.WriteLine();
            }

            Console.WriteLine("SHAPE AREAS:");
            foreach(Shapes shape in listOfShapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
