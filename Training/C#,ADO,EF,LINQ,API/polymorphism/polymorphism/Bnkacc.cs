using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Bnkacc
    {
        private int custid;
        private long accno;
        private string name;
        private double balance;
        private string status;

        public Bnkacc(int custid, long accno, string name, double balance, string status)
        {
            this.Custid = custid;
            this.Accno = accno;
            this.Name = name;
            this.Balance = balance;
            this.Status = status;
        }

        public int Custid { get => custid; set => custid = value; }
        public long Accno { get => accno; set => accno = value; }
        public string Name { get => name; set => name = value; }
        public double Balance { get => balance; set => balance = value; }
        public string Status { get => status; set => status = value; }


        public void CheckStats(long accno, out int custid, out string name,out  double balance, out string status)
        {
            if(accno == Accno) 
            {
                custid = Custid;
                name = Name;
                balance = Balance;
                status = Status;
            }
            
        }

        public void CheckStats(int custid, out long accno, out string name, out double balance, out string status)
        {
            if (custid == Custid)
            {
                accno = Accno;
                name = Name;
                balance = Balance;
                status = Status;
            }

        }
    }
}
