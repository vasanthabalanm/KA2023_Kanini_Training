using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutionAll
{
    internal class Cubes
    {
        private int cube;

        public Cubes(int cube) 
        {
            this.Cube = cube;
        }

        public int Cube { get => cube; set => cube = value; }

        public int squares()
        {
            int res = cube * cube;
            return res ;
        }
    }
}
