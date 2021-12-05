using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp2.Services
{
    class PayPalService : IFee
    {
        public double InstallmentFee(double amount, int nMonth)
        {
            return amount * 0.01 * nMonth;
        }
        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }
        
    }
}
