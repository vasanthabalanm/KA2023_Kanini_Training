using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions1
{
    internal class LoanAccount:Customer
    {
        private int accountNo;
        private int loanAmount;
        private int loanTenureinyrs;

        public LoanAccount(int accountNo, int loanAmount, int loanTenureinyrs, string customerName, int age):base(customerName,age)
        {
            AccountNo1 = accountNo;
            LoanAmount1 = loanAmount;
            LoanTenureinyrs1 = loanTenureinyrs;
        }

        public int AccountNo1 { get => accountNo; set => accountNo = value; }
        public int LoanAmount1 { get => loanAmount; set => loanAmount = value; }
        public int LoanTenureinyrs1 { get => loanTenureinyrs; set => loanTenureinyrs = value; }

        public void loanDisp()
        {
            Console.WriteLine(this.CustomerName);
            Console.WriteLine(this.Age);
            Console.WriteLine(this.AccountNo1);
            Console.WriteLine(this.LoanAmount1);
            Console.WriteLine(this.LoanTenureinyrs1);
        }
    }
}
