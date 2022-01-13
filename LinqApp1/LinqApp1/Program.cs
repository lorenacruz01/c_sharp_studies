using System;
using System.Linq;

namespace LinqApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //especificar data source
            int[] numbers = new int[] { 2, 3, 4, 5, 6 };

            //definir expressão de consulta
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            //executar a consulta
            foreach(int x in result)
            {
                Console.WriteLine(x);
            }


        }
    }
}
