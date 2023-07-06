using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apr7
{
    partial class PartialDemo
    {
        int ans;

        public PartialDemo(int n1,int n2,int ans)
        {
            N1= n1;
            N2= n2;
            ans = 0;
        }
        public partial void calcla()
        {
            Console.WriteLine("From the Partial class demo1!...");
            this.ans = N1 + N2;
            Console.WriteLine(ans);
        }

    }
}
