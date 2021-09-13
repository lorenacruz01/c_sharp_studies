using System;
using System.Collections.Generic;

namespace ListApp1 {
    class Program {
        static void Main(string[] args) {
            
            //List<string> lista = new List<string>();
            //List<string> lista = new List<string> { "Maria", "Alex" };

            List<string> lista = new List<string>();

            //----------adicionando elementos--------------
            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Patrick");
            lista.Add("Bill");

            Console.WriteLine("Insira um nome para ser adicionado à lista");
            lista.Add(Console.ReadLine());

            Console.WriteLine("Insira um nome para ficar em primeiro lugar");
            lista.Insert(0, Console.ReadLine());
            
            Console.WriteLine("Lista modificada: ");
            foreach (string obj in lista) { 
                    Console.WriteLine(obj);
            }
            //----------- verificando tamanho --------------
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Tamanho da lista: " + lista.Count);

            //----Encontrando primeiro ou último elemento com base em um predicado
            string s = lista.Find(Teste);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Primeiro nome com letra incial A: " + s);
            Console.Write("Posição de " + s + ": ");
            int pos = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine(pos);

            Console.WriteLine("---------------------------------------------------");
            string s2 = lista.Find(x => x[0] == 'M'); //utilizando o lambda
            Console.WriteLine("Primeiro nome com letra incial M: " + s2);

            Console.WriteLine("---------------------------------------------------");
            string s3 = lista.FindLast(x => x[0] == 'A'); //utilizando o lambda
            Console.WriteLine("Último nome com letra incial A: " + s3);

            //-------Filtrando um elemento com base em um predicado-----------
            List<string> filtro = lista.FindAll(x => x[0] == 'A');
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Todos os elementos que possuem nome iniciando com A");
            foreach(string obj in filtro) {
                Console.WriteLine(obj);
            }

            //-------Removendo elementos--------------------------------------
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Removendo elementos com a inicial A...");
            //lista.Remove("Alex")
            lista.RemoveAll(x => x[0] == 'A');
            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Removendo elemento que se encontra em primeiro lugar atualmente...");
            //lista.Remove("Alex")
            lista.RemoveAt(0);
            foreach (string obj in lista) {
                Console.WriteLine(obj);
            }
        }

        static bool Teste(string s) {
            return s[0] == 'A';
        }
    }
}
