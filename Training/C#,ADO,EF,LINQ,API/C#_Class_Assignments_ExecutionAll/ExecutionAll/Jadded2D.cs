using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExecutionAll
{
    internal class Jadded2D
    {
        //one dimensional array
        public void display()
        {
            int[][] numbers = new int[4][];
            numbers[0] = new int[] { 1, 2, 3,4 };
            numbers[1] = new int[] { 22, 12, 12, 21, 31 };
            numbers[2] = new int[] { 11, 33, 55, 44, 2, 33 };
            numbers[3] = new int[] { 94, 22, 11, 2102, 101 };


            Console.WriteLine(numbers[3][3]);

            for(int n=0; n<numbers.Length; n++) 
            {
                Console.Write("Row({0}):", n);
                for(int k = 0; k < numbers[n].Length; k++) 
                {
                    Console.Write("{0},",numbers[n][k]);
                }
                Console.WriteLine();
            }
            
            
        }
        public void disp()
        {
            int[][,] numbers = new int[4][,]
            {
                new int [,] {{1,3,8},{5,4,9} },
                new int [,] {{2,3},{6,5} },
                new int [,] {{3,4} },
                new int [,] {{4,5} },
            };
            //jagged array length
            Console.WriteLine(numbers[1][1,1]);

            for (int n = 0; n < numbers.Length; n++)
               
            {
                int x = 0;
                //Length is used 1D array
                //Console.Write("Row({0}):", n);
                for (int j = 0; j < numbers[n].GetLength(x); j++)
                {
                    // Rank = colums 
                    for (int k = 0; k < numbers[j].Rank; k++)
                    //Console.Write("{0},", numbers[n][j]);
                    {
                        Console.Write(numbers[n][j, k] + " ");
                    }
                    Console.WriteLine();
                }

                x++;
                Console.WriteLine();
            }
            
        }
    }
}
