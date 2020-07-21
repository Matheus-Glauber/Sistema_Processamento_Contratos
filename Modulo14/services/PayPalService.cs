using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo14.services
{
    class PayPalService : IOnlinePaymentService
    {
        private const double PERCENTAGEPAYMENTFEE = 1.02;
        private const double INTERESTPERMONTH = 0.01;

        public double PaymentFee(double amount, int months)
        {            
            return ((amount * (INTERESTPERMONTH * months)) + amount) * PERCENTAGEPAYMENTFEE;
        }
    }
}
