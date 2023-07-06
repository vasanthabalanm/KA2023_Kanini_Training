/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    internal class demo2
    {
    }
}*/

/*
 * Author:vbalan
 * date:23 mar 23
 * descrp:access modifiers
 **/
using Control;

class demo2
{
    public static void Main(String[] args) {
        //{ usnig only demo1 classes
                //demo1 demo = new demo1();
                // demo1 demo = new demo1();
                // demo1 loopf = new demo1();
                // Console.Write("enter the  limit:");
                //int max = Convert.ToInt32(Console.ReadLine());
                // demo1 freh = new demo1();
                //string s1 = Console.ReadLine();
                // demo.Bignum();
                /*Console.WriteLine("s==>2 numbers M==>3");
                string ch = Console.ReadLine();
                switch (ch)
                {
                    case "s":
                        demo.Bignum();
                        break;
                    case "M":
                        demo.Bignum();
                        break;
                    default:
                        Console.WriteLine("enter the  correct letter");
                        break;
                }
                //demo.stc();
                //loopf.loop(max);
                //int res = loopf.loop(max);
                //Console.WriteLine(res);
                //freh.frech(s1);
                // demo1 srst = new demo1();
                //srst.srt();
                }
        */

        //both are used abstract with the help of private access specifier 
        BankTransaction bankTransaction = new BankTransaction();
        bankTransaction.ReadCustomerDetails();
        bankTransaction.PerformTranssction();
        bankTransaction.WriteTransaction();

    }
}
