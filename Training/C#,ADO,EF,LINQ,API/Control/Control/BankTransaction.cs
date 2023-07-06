using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    internal class BankTransaction
    {
        private int customerId;
        private long accountNumber;
        private string accountName, status;
        private decimal balance, credit, debit;
        public BankTransaction()
        {
           accountNumber = customerId = 0; 
           accountName = ""; 
           balance = 0;
            status = "Inactive";
            credit = debit = 0;
        }
        public void ReadCustomerDetails()
        {
            Console.WriteLine("Enter the Customerid," + "accountnumber,name,balance");
            customerId = Convert.ToInt32(Console.ReadLine());
            accountNumber = Convert.ToInt64(Console.ReadLine());
            accountName = Console.ReadLine();
            balance = Convert.ToDecimal(Console.ReadLine());
            status = "InActive";
            credit = debit = 0;
        }
        
        public void PerformTranssction()
        {
            
            Console.WriteLine("1.Credit, 2.Debit");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter the credited amount:");
                    credit = Convert.ToDecimal(Console.ReadLine());
                    balance += credit;
                    status = "Active";
                    break;
                case 2:
                    Console.WriteLine("Enter the Debited Amount");
                    debit = Convert.ToDecimal(Console.ReadLine());
                    balance -= debit;
                    status = "Active";
                    break;
                default:
                    Console.WriteLine("Enter 1 or 2 only");
                    break;
            }
            
        }
        //using internal only access within a specific project
        public void WriteTransaction()
        {
        
            Console.WriteLine($"Name:{accountName} - balance:{balance} - status:{status}");
        }

    }
}
