using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractQues
{
    internal class jagar
    {
        public void calc(int limit)
        {
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
