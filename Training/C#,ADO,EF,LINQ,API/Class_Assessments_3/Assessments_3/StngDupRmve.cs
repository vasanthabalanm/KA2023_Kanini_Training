using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments_3
{
    internal class StngDupRmve
    {
        private string str;
        private string str2 = string.Empty;

        public StngDupRmve(string str)
        {
            this.Str = str;
        }

        public string Str { get => str; set => str = value; }
        public string Str2 { get => str2; set => str2 = value; }

        public void rmvdup()
        {

            //Console.WriteLine(this.Str);
            for(int i=0;i<this.Str.Length; i++)
            {
                string temp = this.Str.ToLower();
                if (!this.Str2.Contains(temp[i]))
                {
                    this.Str2 += temp[i];
                }
            }
            Console.WriteLine(this.Str2.ToLower());
        }
    }
}
