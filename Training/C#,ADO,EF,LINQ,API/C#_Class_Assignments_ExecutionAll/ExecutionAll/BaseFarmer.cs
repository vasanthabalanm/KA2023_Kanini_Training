using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutionAll
{
    internal class BaseFarmer
    {
        private int chicken;
        private int cows;
        private int pigs;

        public BaseFarmer(int chicken, int cows, int pigs)
        {
            this.Chicken = chicken;
            this.Cows = cows;
            this.Pigs = pigs;
        }

        public int Chicken { get => chicken; set => chicken = value; }
        public int Cows { get => cows; set => cows = value; }
        public int Pigs { get => pigs; set => pigs = value; }

        public int LegsCount()
        {
            int result = (this.Chicken * 2 + this.Cows * 4 + this.Pigs * 4);
            return result;
        }
    }
}
