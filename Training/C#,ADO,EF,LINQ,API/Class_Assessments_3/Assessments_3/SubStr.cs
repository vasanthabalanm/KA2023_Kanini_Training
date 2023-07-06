using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments_3
{
    internal class SubStr
    {
        private string str1;
        private string str2;

        public SubStr(string str1, string str2)
        {
            this.Str1 = str1;
            this.Str2 = str2;
        }

        public string Str1 { get => str1; set => str1 = value; }
        public string Str2 { get => str2; set => str2 = value; }

        public void subcount()
        {
            int length;
            int index;
            int prefixLen = 0;
                for (int i = 0; i < Math.Min(this.Str1.Length, this.Str2.Length); i++)
                {
                    if (this.Str1[i] == this.Str2[i])
                    {
                        prefixLen++;
                    }
                    else
                    {
                        break;
                    }
                }

                string sub1 = this.Str1.Substring(prefixLen);
                string sub2 = this.Str2.Substring(prefixLen);

                Console.WriteLine($"{prefixLen} {this.Str1.Substring(0, prefixLen)}");
                Console.WriteLine($"{sub1.Length} {sub1}");
                Console.WriteLine($"{sub2.Length} {sub2}");
        }

        
    }
}
