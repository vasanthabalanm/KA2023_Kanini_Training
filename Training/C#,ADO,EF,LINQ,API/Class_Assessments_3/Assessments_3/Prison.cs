using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments_3
{
    internal class Prison
    {
        private long n;
        private int k;

        public Prison(long n,int k) 
        { 
            this.N = n;
            this.K = k;
        }

        public long N { get => n; set => n = value; }
        public int K { get => k; set => k = value; }

        static int SuperDigit(long n)
        {
            if (n < 10)
            {
                return (int)n;
            }
            else
            {
                long digitSum = 0;
                while (n > 0)
                {
                    digitSum += n % 10;
                    n /= 10;
                }
                return SuperDigit(digitSum);
            }
        }
        public void reslt()
        {
            long digitSum = 0;
            while (N > 0)
            {
                digitSum += N % 10;
                N /= 10;
            }
            digitSum *= K;
            Console.WriteLine(SuperDigit(digitSum));
        }

    }
}
