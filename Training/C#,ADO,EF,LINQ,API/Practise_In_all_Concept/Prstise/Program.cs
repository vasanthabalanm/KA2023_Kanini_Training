using InheritanceConcepts;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  child01 child01 = new child01();
              child01.bse();
              base01 base01 = new child01();
              base01.bse();
              child04 child04 = new child05();
              child04.abc();
              //child01 cj = new base01();
              //base01 b = new child01();
              //b.bse();
              cls1 b = new cls1(60);
              b.dis();
              child06 child06 = new chil07();
              child06.sample();
              chil07 chil07 = new chil07();
              chil07.sample();

              child01 child01 = new child01();
              child01.i = 1;
              child01.j = 2;
              child01.display();

              base01 base01 = new child01();
              base01.f1();
              base01.f2();
              base01.f3();

              base01 base01 = new base01();
              child01 child01 = new child01();
              base01 r;
              r = base01;
              r.bse();
              r = child01;
              r.bse();
            child01 child01 = new child01();
              child01.dp();*/

            /*try
            {
                int[] a = { 1, 2, 3, 4, 5 };
                for (int i = 0; i < 5; ++i)
                    Console.WriteLine(a[i]);
                int x = (1 / Convert.ToInt32(0));
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("A");
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("B");
            }


            try
            {
                Console.WriteLine("csharp" + " " + 1 / Convert.ToInt32(0));
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Java");
            }*/

            child01 child01 = new child01();
            child01.i = 1;
            child01.j = 2;
            child01.disp();


        }
    }
}