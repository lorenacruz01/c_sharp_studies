using InterfaceApp2.Entities;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp2.Services
{
    class ProcessPayment
    {
        private IFee FeesOfContractService { get; set; }

        public ProcessPayment(IFee feesOfContractService)
        {
            FeesOfContractService = feesOfContractService;
        }

        public void ProcessContractService(Contract contract)
        {
            int numberOfMonths = contract.NumberOfInstallments;
            double initialAmount = contract.InitialValuePerMonth();
            for(int i = 1; i <= numberOfMonths; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                double totalAmount = initialAmount + FeesOfContractService.InstallmentFee(initialAmount, i);
                totalAmount = totalAmount + FeesOfContractService.PaymentFee(totalAmount);
                contract.AddNewInstallment(new Installment(dueDate, totalAmount));
            }
        }
    }
}
