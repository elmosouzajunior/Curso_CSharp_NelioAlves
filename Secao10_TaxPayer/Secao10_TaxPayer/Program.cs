using System;
using Secao10_TaxPayer.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Secao10_TaxPayer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company (C/I): ");
                char typeOfPayer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (typeOfPayer == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployess = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployess));
                }
                Console.WriteLine();
            }

            Console.WriteLine("TAXES PAID:");
            foreach(TaxPayer payer in list)
            {
                Console.WriteLine(payer.Name + ": $ " + payer.TaxCalculator().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine();
            double totalTax = 0.0;
            foreach (TaxPayer payer in list)
            {
                totalTax += payer.TaxCalculator();
            }
            Console.Write("TOTAL TAXES: " + totalTax.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
