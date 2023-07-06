using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssessment
{
    internal class ATM
    {
        private double balance;

        public ATM()
        {
           balance = 100;
        }

        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if(amount<=balance)
                {
                    balance -= amount;
                    Console.WriteLine(balance);
                }
            }

        }
        public void Deposit(double amount)
        {
            if(amount > 0)
            {
                balance += amount;
                Console.WriteLine($"{amount} {balance}");
            }

        }
        public void Balance()
        {

        }
    }
    
}
