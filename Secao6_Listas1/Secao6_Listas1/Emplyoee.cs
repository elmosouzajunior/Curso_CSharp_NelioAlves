using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Secao6_Listas1
{
    class Emplyoee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Emplyoee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void SalaryIncreaser(double percentIncrease)
        {
            Salary *= Salary + (percentIncrease / 100);
        }

        public override string ToString()
        {
            return (Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
