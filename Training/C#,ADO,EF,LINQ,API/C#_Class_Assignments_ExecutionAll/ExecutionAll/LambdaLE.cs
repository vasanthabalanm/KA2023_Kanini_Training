using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutionAll
{
    internal class LambdaLE
    {
        //=>is a lambda expression already used in js in their pronounced as arrow function
        public void evennums()
        {
            List<int> numbers = new List<int>() { 10, 5, 53, 34, 23, 232, 32 };

            List<int> evennums = numbers.FindAll(n => ((n % 2) == 0));
           

            foreach (int n in evennums) 
            {
                Console.WriteLine(n);
            }
        }

       
        
    }
}
