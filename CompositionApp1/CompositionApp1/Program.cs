using System;
using System.Globalization;
using CompositionApp1.Entities;
using CompositionApp1.Entities.Enums;

namespace CompositionApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o nome do departamento: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Preecha os dados a seguir.");
            Console.Write("Nome do funcionário: ");
            string name = Console.ReadLine();
            Console.Write("Nível de experiência (Junior/Midlevel/Senior)");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário base: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);
            Console.WriteLine("Funcionário cadastrado com sucesso!");
            Console.WriteLine("-----------------------------------");
            Console.Write("Quantos contratos serão cadastrados? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com os dados do contrato {i}");
                Console.Write("Data DD/MM/YYYY: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duração (horas): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            



        }
    }
}
