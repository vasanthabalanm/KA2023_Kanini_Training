using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLinq
{
    internal class Voters
    {
        //consider as meathod being a delegate in main program.cs
        public static List<people> where(people[] pep ,EligibityCheck del)
        {
            List<people> voter = new List<people>();
            foreach  (people pe in pep)
            {
                if (del(pe))
                {
                    voter.Add(pe);
                }   
            }
            return voter;

        }

    }
}
