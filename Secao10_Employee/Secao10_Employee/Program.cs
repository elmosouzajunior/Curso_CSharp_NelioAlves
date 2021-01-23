using System;
using Secao10_Employee.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace Secao10_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listOfEmployess = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int numberEmployees = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= numberEmployees; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (outsourced == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listOfEmployess.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    listOfEmployess.Add(new Employee(name, hours, valuePerHour));                   
                }
                Console.WriteLine();
            }

            Console.WriteLine("PAYMENTS:");
           foreach(Employee empl in listOfEmployess)
            {
                Console.WriteLine(empl.Name + " - $ " + empl.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
