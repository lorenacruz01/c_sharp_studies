using ExceptionsApp2.Entities;
using ExceptionsApp2.Entities.Exceptions;
using System;
using System.Globalization;

namespace ExceptionsApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("----Enter account data----");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter the amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            } 
            catch (DomainException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            } 
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
            



        }
    }
}
