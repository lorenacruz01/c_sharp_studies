using InterfaceApp2.Entities;
using InterfaceApp2.Services;
using System;
using System.Globalization;

namespace InterfaceApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data ");
            Console.WriteLine("--------------------");
            Console.Write("Number: ");
            int numberOfContract = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/mm/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int numberOfInstallments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(numberOfContract, date, contractValue, numberOfInstallments);
            ProcessPayment processPayment = new ProcessPayment(new PayPalService());

            processPayment.ProcessContractService(contract);

            foreach(Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
