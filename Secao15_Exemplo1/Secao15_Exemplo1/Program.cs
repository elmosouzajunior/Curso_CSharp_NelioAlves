using System;
using System.Collections.Generic;

namespace Secao15_Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many values? ");
            int values = int.Parse(Console.ReadLine());
            PrintService<int> printService = new PrintService<int>();
            for(int i = 0; i < values; i++)
            {
                printService.AddValue(int.Parse(Console.ReadLine()));
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());            
        }
    }
}
