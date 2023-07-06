using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Apr7
{
    internal static class SticDemo
    {
        static int consumerno, prereading, currntreading;
        static double amt;

        public static int Consumerno { get => consumerno; set => consumerno = value; }
        public static int Prereading { get => prereading; set => prereading = value; }
        public static int Currntreading { get => currntreading; set => currntreading = value; }
        public static double Amt { get => amt; set => amt = value; }

       
        static SticDemo()
        {
            if ((currntreading - prereading) <= 100)
            {
                Amt = 0;
            }
           
        }

        //plese note if use staatic class all types,meathods,variables all must be static..!
        public static void metd1Calc(int cr,int pr)
        {
            int usag = (cr - pr);
            if(usag >100 && usag <= 200)
            {
                amt = usag*2;
            }
            else
            {
                amt = usag * 4;
            }
        }
        //plese note if use staatic class all types,meathods,variables all must be static..!
        public static void disp()
        {
            Console.WriteLine("plese note if use staatic class all types,meathods,variables all must be static..!");
        }
    }
}
