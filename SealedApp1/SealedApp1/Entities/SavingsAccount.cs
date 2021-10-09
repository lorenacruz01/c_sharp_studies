using System;
using System.Collections.Generic;
using System.Text;

namespace SealedApp1.Entities
{
    //sealed class SavingsAccount : Account -> Sela a classe
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance = Balance * InterestRate;
        }

        //sobrescrita do Withdraw da superclasse Account
        public sealed override void Withdraw(double amount) //sealed sela o método e o impede de ser herdado
        {
            base.Withdraw(amount);
            Balance -= 1.0;
        }
    }
}
