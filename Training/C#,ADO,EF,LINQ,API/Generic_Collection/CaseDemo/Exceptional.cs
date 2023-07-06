using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseDemo
{
    internal class Exceptional
    {
        private int num1, num2, num3;

        public Exceptional(int num1, int num2, int num3) 
        { 
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }
        public int Add()
        {
            this.num3=this.num1+this.num2;
            return this.num3;
        }
        public int numltiply()
        {
            this.num3=this.num1*this.num2;
            return this.num3;
        }
        public int division()
        {
            int[] num = { 10, 0 };
            try
            {
                this.num3 = this.num1 / this.num2;
                int x = num[0] / num[1];
               // return this.num3;
            }
            catch(DivideByZeroException expect) 
            {
                Console.WriteLine("Don't give zero '0 for denominator");
                Console.WriteLine(expect.Message);
                //return 0;
            }
            finally
            {
                Console.WriteLine("ok");
            }
            return this.num3;
            
            
        }
        public void check(int val)
        {
            if (val < 0)
            {
                throw new ArgumentException("Don't insertthe value zero");
            }
            else if (val < 18) 
            {
                throw new ArithmeticException("value shoukd > 18");
            }
            else
            {
                Console.WriteLine("Ok it's fine");
            }
        }
    }
}
