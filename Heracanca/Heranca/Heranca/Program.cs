using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Rogerio", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Joaquim", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Gabriel", 0.0, 0.01);

            // DOWNCASTING
            BusinessAccount bacc4 = (BusinessAccount)acc2;
            bacc4.Loan(100.00);

            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.00);
                Console.WriteLine("Loan !");
            }

            if (acc3 is SavingsAccount)
            {
                // SavingsAccount acc5 = (SavingsAccount)acc3; => Funciona
                SavingsAccount acc5 = acc3 as SavingsAccount; // Nova forma de fazer o casting
                acc5.UpdateBalance();
                Console.WriteLine("Update !");
            }
        }
    }
}
