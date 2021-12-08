using IComparableApp1.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace IComparableApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\workspace\c_sharp_studies\IComparableApp1\teste.txt";
            Console.WriteLine("teste");
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach(Employee str in list)
                    {
                        Console.WriteLine(str);
                    }
                }
            } catch(IOException e)
            {
                Console.WriteLine("An error has ocurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
