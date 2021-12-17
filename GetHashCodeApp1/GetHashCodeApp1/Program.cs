using System;

namespace GetHashCodeApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Maria";
            string b = "Maria";
            //dentro da mesma execução, mostra o mesmo hashcode
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
