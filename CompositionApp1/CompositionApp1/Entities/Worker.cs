﻿using System;
using System.Globalization;
using System.Collections.Generic;
using CompositionApp1.Entities.Enums;

namespace CompositionApp1.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //garantir que não seja nula

        //construtores
        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract( HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    Console.WriteLine(sum);
                    sum += contract.TotalValue();
                }
                
            }

            return sum;
        }

        public override string ToString()
        {
            return "Nome: " + Name + ", Nível: " + Level + ", Departamento: " + Department.Name + ", Salário Base: " + BaseSalary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
