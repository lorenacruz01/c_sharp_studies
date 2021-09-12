using System;

namespace RefOutApp1 {
    class Program {
        static void Main(string[] args) {
            //utilizando o ref é obrigatório iniciar a variável original
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            //utilizando o out
            int b = 10;
            int triple;
            Calculator2.Triple2(b, out triple);
            Console.WriteLine(triple);

        }
    }
}
