using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractionclass
{
    internal class class1:bankdetils
    {
        private int intrstpercentage;
        
        public class1(int intrintrstpercentagesr, int accno, string name, double amount, double intialamount) :base( accno,  name,  amount, intialamount)
        {
            this.Intrstpercentage = intrintrstpercentagesr;
        }

        public int Intrstpercentage { get => intrstpercentage; set => intrstpercentage = value; }
        
        public override double calculateinterset()
        {
            Intialamount = ( Amount * intrstpercentage)/100;
            return Intialamount;
        }
    }
}
