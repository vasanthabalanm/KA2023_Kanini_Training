using System;

namespace Assessments_3 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //1.
            /*try
            {
                FileConcept concept = new FileConcept();
                // concept.createfile();
                concept.Writefile();
                concept.Readfile();
                concept.Written();
            }
            catch
            {
                Console.WriteLine("the file doesnot implement ");
            }*/

            //2.
            /*string str = Console.ReadLine();
            StngDupRmve stngDupRmve = new StngDupRmve(str);
            stngDupRmve.rmvdup();*/

            //3.
            /*string str = Console.ReadLine();
            CntStr cntStr = new CntStr(str);
            cntStr.cnt();*/

            //4.
            /*string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            SubStr subStr = new SubStr(str1,str2);
            subStr.subcount();*/

            //5.
            /*int n = int.Parse(Console.ReadLine());
            BallColor ballColor = new BallColor(n);
            ballColor.res();*/

            //6.
            /*string[] inputs = Console.ReadLine().Split(' ');
            long n = long.Parse(inputs[0]);
            int k = int.Parse(inputs[1]);
            Prison prison = new Prison(n, k);
            prison.reslt();*/

            //7
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Buses buses = new Buses(n,m);
            buses.fetchs();










        }


    }
}