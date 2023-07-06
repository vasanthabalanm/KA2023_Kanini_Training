using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutionAll
{
    internal class ProfitableGaming
    {
        private double prob;
        private int prize;
        private int pay;

        public ProfitableGaming(double prob, int prize, int pay) 
        {
            this.Prob = prob;
            this.Prize = prize;
            this.Pay = pay;
        }

        public double Prob { get => prob; set => prob = value; }
        public int Prize { get => prize; set => prize = value; }
        public int Pay { get => pay; set => pay = value; }

        public bool calc()
        {
            if (this.Prob * this.Prize > this.Pay)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
