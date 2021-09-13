using System;
using System.Globalization;

namespace MatrixApp2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre com o valor de n da primeira matriz quadrada: ");
            int n = int.Parse(Console.ReadLine());

            double[,] mat = new double[n, n];

            Console.WriteLine("--------------------------------------------");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write("Insira o elemento [ " + i + ", " + j + " ]: ");
                    double ans = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    mat[i, j] = ans;
                }
            }
            
            PrintMatrix(mat);
            PrintDiagonal(mat);

            Console.Write("Entre com o valor de n da segunda matriz quadrada: ");
            int c = int.Parse(Console.ReadLine());

            double[,] mat2 = new double[c, c];

            Console.WriteLine("--------------------------------------------");
            for (int i = 0; i < c; i++) {
                Console.WriteLine("Insira os elementos da linha " + i + "(separados por espaço): ");
                string[] vect = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++) {

                    mat2[i, j] = double.Parse(vect[j], CultureInfo.InvariantCulture);
                }
            }
            PrintMatrix(mat2);
            PrintDiagonal(mat2);
        }
        static void PrintMatrix(double[,] mat) {
            int n = mat.GetLength(0);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Matriz");
            for (int i = 0; i < n; i++) {
                
                for (int j = 0; j < n; j++) {
                    Console.Write(mat[i,j].ToString("F2", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------");
        }
        static void PrintDiagonal(double[,] mat) {
            int n = mat.GetLength(0);
            Console.Write("Diagonal principal da matriz: ");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i,i] + " ");
                
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
        }

    }
}
