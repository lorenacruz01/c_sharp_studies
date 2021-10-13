using AbstractClassApp1.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AbstractClassApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //mesmo a classe sendo abstrata, é possível colocar todos os tipos de conta em uma mesma coleção
            List<Account> lista = new List<Account>();

            lista.Add(new SavingsAccount(1001,"Alex",500.00, 0.01));
            lista.Add(new BusinessAccount(1001,"Maria", 500.00, 400.00));
            lista.Add(new SavingsAccount(1003, "Bob", 500.00, 0.01));
            lista.Add(new BusinessAccount(1004, "Ana", 500.00, 500.00));

            double sum = 0.0;
            foreach(Account conta in lista)
            {
                sum += conta.Balance;
            }
            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Withdrawing $10 from each account...");
            
            foreach (Account conta in lista)
            {
                conta.Withdraw(10.00);
                Console.WriteLine("Updated Balnce for account number " + conta.Holder + ": " 
                    + conta.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            

        }
    }
}
