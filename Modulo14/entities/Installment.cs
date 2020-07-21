using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Modulo14.entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment()
        {
        }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.Date
                   + " - "
                   + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
