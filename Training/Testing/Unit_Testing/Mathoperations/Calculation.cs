using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathoperations
{
    public class Calculation
    {
        private int num1, num2;
        public Calculation(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
/*            this.Ans = ans;
*/        }

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }
/*        public int Ans { get => ans; set => ans = value; }
*/
        public int Add()
        {
            return Num1 + Num2;
        }
        public int Sub()
        {
            return Num1 - Num2;
        }

        public int Mul()
        {
            return Num1 * Num2;
        }

    }
}
