using System;
using System.Collections.Generic;
using System.Text;

namespace MulticastDelegatesApp1.Services
{
    class CalculationServices
    {
        public static void ShowMax(double x, double y)
        {
            double max = (x > y) ? x : y;
            Console.WriteLine(max);
        }

        public static void ShowSum(double x, double y)
        {
            double result = x + y;
            Console.WriteLine(result);
        }
    }
}
