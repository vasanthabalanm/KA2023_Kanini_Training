using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractionclass
{
    abstract class bankdetils
    {
        private int accno;
        private string name;
        private double amount;
        private double intialamount;

        public bankdetils(int accno, string name, double amount, double intialamount)
        {
            this.Accno = accno;
            this.Name = name;
            this.Amount = amount;
            this.Intialamount = intialamount;
        }

        public int Accno { get => accno; set => accno = value; }
        public string Name { get => name; set => name = value; }
        public double Amount { get => amount; set => amount = value; }
        public double Intialamount { get => intialamount; set => intialamount = value; }


        public abstract  double calculateinterset();
        
    }
}
