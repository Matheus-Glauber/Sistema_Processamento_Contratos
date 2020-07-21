using Modulo14.entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Modulo14.services
{
    class ContractServices
    {
        IOnlinePaymentService _onlinePayment;

        public ContractServices(IOnlinePaymentService onlinePayment)
        {
            _onlinePayment = onlinePayment;
        }

        public void ProcessContracts(Contract contract, int months)
        {
            double value = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {                
                double amount = _onlinePayment.PaymentFee(value, i);
                contract.AddInstallment(new Installment(contract.Date.AddMonths(i), amount));
            }
        }
    }
}
