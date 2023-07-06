using AbstractQues;
using System;

namespace AbrstactQues // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           
            Console.Write("Enter limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[limit];

            for (int i = 0; i < limit; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < limit; i++)
            {
                for (int j = i + 1; j < limit; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
           
            Console.Write(String.Join(",", arr));



        }
    }
}