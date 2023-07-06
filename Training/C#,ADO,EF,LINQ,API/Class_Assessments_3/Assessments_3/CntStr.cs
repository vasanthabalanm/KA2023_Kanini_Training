using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments_3
{
    internal class CntStr
    {
        private string str;
        public CntStr(string str) 
        { 
            this.Str = str;
        }

        public string Str { get => str; set => str = value; }

        public void cnt()
        {
            string str2 = "";
            int count = 1;
            for (int i = 1; i < this.Str.Length; i++)
            {
                if (this.Str[i] == this.Str[i - 1])
                {
                    count++;
                }
                else
                {
                    str2 += this.Str[i - 1] ;
                    count = 1;
                }
            }
            str2 += this.Str[this.Str.Length - 1] + count.ToString();

            Console.WriteLine(str2.ToLower());

        }
    }
}
