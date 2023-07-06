using CaseDemo;
using System;
using System.Reflection.Emit;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter 2 numbers");
            Exceptional exceptional = new Exceptional(10, 10, 0);
            // Console.WriteLine(exceptional.Add());
            //Console.WriteLine(exceptional.numltiply());
            //Console.WriteLine(exceptional.division());
            /*try
            {
                exceptional.check(10);
            }
            catch (ArgumentException ex) 
            {
            Console.WriteLine("argu");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("art");
            }
            
            int x = 1; float y = 2.4f; short z = 1;
            Console.WriteLine(x + (y * z) - (x += (short)y)); Console.ReadLine();*/

            //File1 file1 = new File1();
            //file1.CreateFile();
            //file1.DeleteFile();
            //file1.Coping();
            //file1.Writedata();
            //
            //file1.ReadDatas();

            genricOllection genricOllection = new genricOllection();
            genricOllection.ListElements();
        }
    }
}