using GetHashCodeApp1.Entities;
using System;

namespace GetHashCodeApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client("Maria", "maria@gmail.com");
            Client b = new Client("Alex", "maria@gmail.com");

            Console.WriteLine("a equals b? ");
            Console.WriteLine(a.Equals(b)); //iguais do ponto de vista do conteudo?
            Console.WriteLine("--------------");
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

        }
    }
}
