using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutionAll
{
    internal class Cofee
    {


        private int cups;

        public int Cups { get => cups; set => cups = value; }

        public int TotalCups(int cups)
        {
            int total_cups = (cups / 6) + cups;
            return total_cups;
        }


    }
}
