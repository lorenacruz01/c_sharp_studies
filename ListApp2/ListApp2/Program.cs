using System;
using System.Globalization;
using System.Collections.Generic;
namespace ListApp2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Olá! Quantos funcionários gostaria de cadastrar?");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for(int i = 0; i < n; i++) {
                Console.WriteLine("#Funcionário " + (i+1) + " : ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                

                lista.Add(new Funcionario(id, nome, salario));
                Console.WriteLine("Funcionário cadastrado com sucesso!");
                Console.WriteLine();
            }

            Console.WriteLine("Digite o id do funcionário que irá receber o aumento");
            int idCompare = int.Parse(Console.ReadLine());

            Funcionario idEmployee = lista.Find(x => x.Id == idCompare);
            while(idEmployee == null) {
                Console.WriteLine("Não foi possível encontrar o id! Digite novamente.");
                idCompare = int.Parse(Console.ReadLine());
                idEmployee = lista.Find(x => x.Id == idCompare);
            }

            Console.WriteLine("Qual a porcentagem do aumento?");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            idEmployee.Aumento(porcentagem);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Lista Atualizada: ");
            foreach(Funcionario obj in lista) {
                Console.WriteLine(obj);
            }
            

            

        }


    }
}
