using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo14.entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> Installments { get; private set; }

        public Contract()
        {
        }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public Contract(int number, DateTime date, double totalValue, List<Installment> installments)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = installments;
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
