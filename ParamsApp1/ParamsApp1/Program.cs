using System;
using System.Globalization;

namespace ParamsApp1 {
    class Program {
        static void Main(string[] args) {
            //sem o params: double result = Calculator.Sum(new int[] {1, 2});
            double result = Calculator.Sum(1.5, 2.7);
            Console.WriteLine("result = " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
