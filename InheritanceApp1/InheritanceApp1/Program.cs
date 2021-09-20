using System;
using System.Globalization;
using InheritanceApp1.Entities;

namespace InheritanceApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Alex Von Hohenheim", 100.0, 500);
            Console.WriteLine(account.Balance);

            account.Withdraw(10.5);

            Console.WriteLine(account.Balance.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
