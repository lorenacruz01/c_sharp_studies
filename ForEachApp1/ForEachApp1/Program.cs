using System;

namespace ForEachApp1 {
    class Program {
        static void Main(string[] args) {
            //criar o vetor
            string[] vect = new string[] { "Maria", "Bob", "Alex" };
            //para cada objeto em vect, fazer tal coisa
            foreach(string obj in vect) {
                Console.WriteLine(obj);
            }
        }
    }
}
