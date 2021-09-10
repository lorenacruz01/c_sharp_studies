using System;

namespace ArrayApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Cadastro[] rooms = new Cadastro[10];
            int counter = 0;
            Console.WriteLine("Olá! Quantos quartos gostaria de alugar?");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Vamos iniciar os cadastros");
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine($"Cadastro {i + 1}");

                Console.Write("Insira o nome: ");
                string name = Console.ReadLine();

                Console.Write("Insira o email: ");
                string email = Console.ReadLine();

                Console.Write("Insira o número do quarto desejado: ");
                int number = int.Parse(Console.ReadLine());

                rooms[i] = new Cadastro { ClientName = name, Email = email, RoomNumber = number };
                if (counter != 0)
                {


                    //checa se o quarto está ocupado
                    for (int j = 0; j < counter; j++)
                    {
                        if (rooms[j].RoomNumber == number)
                        {
                            Console.WriteLine("Quarto ocupado! Por favor, escolha outro");
                            number = int.Parse(Console.ReadLine());
                            rooms[i] = new Cadastro { ClientName = name, Email = email, RoomNumber = number};
                            j = -1;
                        }
                    }



                }
                counter++;
                Console.WriteLine("Quarto reservado com sucesso.");
            }

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Reservas feitas: ");
            for (int i = 0; i < 10; i++)
            {
                if(rooms[i] != null)
                {
                    Console.WriteLine(i + ": " + rooms[i]);
                }
            }
            Console.WriteLine("----------------------------------------------------");


        }

    }
}
