using System;
using System.Globalization;

namespace InterfaceApp2.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return "Due date: " + DueDate.ToString("dd/MM/yyyy")
                + " - Amount: " + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
