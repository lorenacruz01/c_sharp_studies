using System;
using System.Globalization;
using UpAndDownCastingApp1.Entities;

namespace UpAndDownCastingApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* BusinessAccount account = new BusinessAccount(8010, "Alex Von Hohenheim", 100.0, 500);
             Console.WriteLine(account.Balance);

             account.Withdraw(10.5);

             Console.WriteLine(account.Balance.ToString("F2", CultureInfo.InvariantCulture));*/

            Account acc = new Account(1050, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1051, "Maria", 0.0, 500.00);

            //UPCASTING (conversão da subclasse para superclasse)

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1235, "Bob", 0.0, 200);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //DOWNCASTING (conversão da superclasse para subclasse)

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.00);

            // uso do is
            if(acc is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(100.00);
                Console.WriteLine("Empréstimo feito com sucesso!");
            }

            if(acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }

        }
    }
}