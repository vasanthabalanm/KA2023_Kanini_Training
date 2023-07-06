using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssessment
{
    internal class Ques1
    {
       public void vowel()
        {
            Console.WriteLine("enter the String:");
            string name = Console.ReadLine();
            int count = 0;

            /*char[] vowel = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            foreach (char c in name)
            {
                if(Array.Exists( vowel, vowels=>vowels==c))
                {
                    count++;
                }
            }
            Console.WriteLine(count);*/

            for(int i = 0; i < name.Length; i++)
            {
                if (name[i] =='a' || name[i] =='e' || name[i]=='i' || name[i]=='o' || name[i] == 'u' || name[i] == 'A' || name[i] == 'E' || name[i] == 'I' || name[i] == 'O' || name[i] == 'U')
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }
    }
}
