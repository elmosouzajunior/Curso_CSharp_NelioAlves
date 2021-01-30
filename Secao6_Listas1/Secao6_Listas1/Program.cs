using System;
using System.Globalization;
using System.Collections.Generic;

namespace Secao6_Listas1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int numberEmployess = int.Parse(Console.ReadLine());

            List<Emplyoee> listOfEmployees = new List<Emplyoee> (); 

            for (int i = 0; i < numberEmployess; i++)
            {
                Console.WriteLine("Employee: #" + (i+1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listOfEmployees.Add(new Emplyoee(id, name, salary));
                Console.WriteLine("");
            }

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Updated list of Employees:");
            foreach (Emplyoee employee in listOfEmployees)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("");
            Console.Write("Enter the employee id that will have salary increase: ");
            int idToIncrease = int.Parse(Console.ReadLine());
            
            Emplyoee emp = listOfEmployees.Find(x => x.Id == idToIncrease);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.SalaryIncreaser(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Updated list of Employees:");
            foreach (Emplyoee employee in listOfEmployees)
            {
                Console.WriteLine(employee);
            }


        }
    }
}
