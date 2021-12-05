using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp2.Services
{
    interface IFee
    {
        double PaymentFee(double paymentFee);
        double InstallmentFee(double InstallmentFee, int nMonth);

    }
}
