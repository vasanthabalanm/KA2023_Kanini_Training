using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseDemo
{
    internal class genricOllection
    {
        public void ListElements()
        {
            List<int> numbers = new List<int>();
            numbers.Add(0);
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            /* for(int i = 0; i < numbers.Count; i++) 
             {
                 Console.WriteLine(numbers[i]);
             }*/
             
            numbers.Append(20);
            
        }
    }
}
