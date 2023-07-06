using System;
using System.Security.Cryptography.X509Certificates;

namespace Apr7 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main(string[] args)
        { }
        /*Console.WriteLine("Enter the consumer number:");
        int cons = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Current Reading:");
        int curr = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Enter the PReReading:");
        int prer = Convert.ToInt32(Console.ReadLine());
        SticDemo.metd1Calc(curr,prer);
        Console.WriteLine(SticDemo.Amt);



        PartialDemo partialDemo = new PartialDemo(10,10,0);
        partialDemo.calcla();*/

        class X
        {
            protected virtual void F()
            {
                Console.WriteLine("X.F");
            }
            protected virtual void F2()
            {
                Console.WriteLine("X.F2");
            }
        }
        class Y : X
        {
            sealed protected override void F()
            {
                Console.WriteLine("Y.F");
            }
            protected override void F2()
            {
                Console.WriteLine("X.F3");
            }
        }
        class Z : Y
        {
            // Attempting to override F causes compiler error CS0239.
            //
            /* protected override void F()
             {
                 Console.WriteLine("C.F");
             }*/
            // Overriding F2 is allowed.
            protected override void F2()
            {
                Console.WriteLine("Z.F2");
            }
        }
    
    }
}
