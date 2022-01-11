using DelegatesApp1.Services;
using System;

namespace DelegatesApp1
{
    class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2); //especifica uma referência para uma função que recebe dois numeros double e retorna um double

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationServices.Sum;

            //double result = op(a, b);
            double result = op.Invoke(a, b);
            Console.WriteLine(result);
        }
    }
}
