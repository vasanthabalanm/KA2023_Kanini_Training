using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions1
{
    internal class SavingsAccount:Customer
    {
        private int accountNumber;
        private int amount;
        private string branchName;
        private string iFSC;

        public SavingsAccount(int accountNumber, int amount, string branchName, string iFSC, string customerName, int age):base(customerName,age)
        {
            this.AccountNumber = accountNumber;
            this.Amount = amount;
            this.BranchName = branchName;
            this.IFSC = iFSC;
        }

        public int AccountNumber { get => accountNumber; set => accountNumber = value; }
        public int Amount { get => amount; set => amount = value; }
        public string BranchName { get => branchName; set => branchName = value; }
        public string IFSC { get => iFSC; set => iFSC = value; }


        public void savngDisp()
        {
            Console.WriteLine(this.CustomerName);
            Console.WriteLine(this.Age);
            Console.WriteLine(this.AccountNumber);
            Console.WriteLine(this.BranchName);
            Console.WriteLine(this. IFSC);
        }
    }
}
