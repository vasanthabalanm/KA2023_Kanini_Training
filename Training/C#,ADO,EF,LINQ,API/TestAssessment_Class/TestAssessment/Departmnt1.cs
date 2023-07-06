using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssessment
{
    internal class Departmnt1:Company
    {

       
        public void BonusD1()
        {
            Console.WriteLine("enter the details: basicamount,bonus is5 only");
            int basicAmount = Convert.ToInt32(Console.ReadLine());
            double bounus = Convert.ToDouble(Console.ReadLine());

            double bnsAmt = basicAmount * (bounus/100);

            Console.WriteLine(bnsAmt);
            

        }
    }
}
