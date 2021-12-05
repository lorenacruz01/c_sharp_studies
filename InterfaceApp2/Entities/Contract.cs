using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace InterfaceApp2.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }
        public int NumberOfInstallments { get; set; }

        public Contract(int number, DateTime date, double totalValue, int numberOfInstallments)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
            NumberOfInstallments = numberOfInstallments;
        }

        public void AddNewInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
        public double InitialValuePerMonth()
        {
            double amount = (double)(TotalValue / NumberOfInstallments);
            return amount;
        }
    }
}
