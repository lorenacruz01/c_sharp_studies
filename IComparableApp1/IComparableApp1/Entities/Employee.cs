using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace IComparableApp1.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] v = csvEmployee.Split(',');
            Name = v[0];
            Salary = double.Parse(v[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Salary: " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argumento is not an Employee");
            }
            Employee other = obj as Employee;
            return Salary.CompareTo(other.Salary);
        }
    }
}
