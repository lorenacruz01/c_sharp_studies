using SealedApp1.Entities;
using System;
using System.Globalization;

namespace SealedApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1050, "Alex", 500.0);
            //fazendo upcasting
            Account acc2 = new SavingsAccount(1002, "Ana", 500.0, 0.01);
            Account acc3 = new BusinessAccount(1042, "Bob", 500.0, 1500.0);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);
            acc3.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            Console.WriteLine(acc3.Balance);
        }
    }
}
