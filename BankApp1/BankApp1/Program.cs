using System;
using System.Globalization;

namespace BankApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            Console.Write("Olá! Digite o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Agora, digite o nome do titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Deseja realizar um depósito inicial (S/N)?");
            char result = char.Parse(Console.ReadLine());

            if(result == 'S' || result == 's')
            {
                Console.Write("Digite o valor do depósito: ");
                double dinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, nome, dinheiro);
            }
            else
            {
                conta = new Conta(numero, nome);
            }
            Console.WriteLine("");
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine("");
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine("");
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);


        }
    }
}
