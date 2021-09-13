using System;

namespace MatrixApp1 {
    class Program {
        static void Main(string[] args) {

            int linhas = 2;
            int colunas = 3;
            double[,] mat = new double[linhas, colunas];

            //quantidade de elementos (tamanho da matriz)
            Console.WriteLine("A matriz possui " + mat.Length + " elementos");

            //quantidade de linhas
            Console.WriteLine("A matriz possui " + mat.Rank + " linhas"); //poderia usar mat.GetLength(0)
            Console.WriteLine("A matriz possui " + mat.GetLength(1) + " colunas");

        }
    }
}
