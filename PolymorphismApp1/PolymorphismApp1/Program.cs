using System;
using System.Globalization;
using System.Collections.Generic;
using PolymorphismApp1.Entities;

namespace PolymorphismApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Employee> employees = new List<Employee>();
            Console.Write("Insira o número de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i}");
                Console.Write("Outsourced (y/n)? ");
                char ans = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ans == 'y')
                {
                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, addCharge));
                } 
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach(Employee emp in employees)
            {
                Console.WriteLine("Name: " + emp.Name + " $: " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
                
        }
    }
}