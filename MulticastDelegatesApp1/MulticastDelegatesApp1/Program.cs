using MulticastDelegatesApp1.Services;
using System;

namespace MulticastDelegatesApp1
{
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 15;
            double b = 17;

            BinaryNumericOperation op = CalculationServices.ShowSum;
            op += CalculationServices.ShowMax;
            op.Invoke(a, b);
        }
    }
}
