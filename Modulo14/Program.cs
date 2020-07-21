using Modulo14.entities;
using Modulo14.services;
using System;
using System.Collections.Generic;

namespace Modulo14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            DateTime date = DateTime.Now;

            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine());

            Console.Write("Enter number of installments: ");
            int installmentsNumber = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value, new List<Installment>());

            ContractServices contractService = new ContractServices(new PayPalService());

            contractService.ProcessContracts(contract, installmentsNumber);

            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment.ToString());
            }
        }
    }
}
