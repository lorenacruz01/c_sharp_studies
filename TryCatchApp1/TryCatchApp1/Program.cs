using System;
using System.Globalization;

namespace TryCatchApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o primeiro número: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine("Resultado: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é permitido divisão por zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro! O input deve ser numérico");
            }
           
        }
    }
}
