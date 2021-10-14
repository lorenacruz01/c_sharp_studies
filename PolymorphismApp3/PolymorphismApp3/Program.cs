using PolymorphismApp3.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace PolymorphismApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> lista = new List<Pessoa>();
            Console.Write("Digite o número de pagadores de impostos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"--------Pagador #{i}--------");
                Console.Write("Pessoa Física ou jurídica (f/j)? ");
                char type = char.Parse(Console.ReadLine());
                if(type == 'f' || type == 'j')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Renda Anual: ");
                    double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (type == 'f')
                    {
                        Console.Write("Gastos com saúde: ");
                        double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        lista.Add(new PessoaFisica(nome, rendaAnual, gastoSaude));
                    }
                    else if (type == 'j')
                    {
                        Console.Write("Número de funcionários: ");
                        int num = int.Parse(Console.ReadLine());
                        lista.Add(new PessoaJuridica(nome, rendaAnual, num));
                    }
                } else
                {
                    Console.WriteLine("Tipo não reconhecido. Por favor, tente novamente");
                    i--;
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("--------Impostos a Pagar-------");
            double sum = 0.0;
            foreach(Pessoa pessoa in lista)
            {
                sum += pessoa.Imposto();
                Console.WriteLine(pessoa.Nome + ": $" + pessoa.Imposto().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Imposto Total: $" + sum.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("-------------------------------");

        }
    }
}
