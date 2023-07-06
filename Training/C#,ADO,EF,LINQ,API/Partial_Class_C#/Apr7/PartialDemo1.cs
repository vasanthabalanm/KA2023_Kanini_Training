using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apr7
{
    //change file name as PartialDemo to PartialDemo1
    //click no to change
    partial class PartialDemo
    {
        int n1, n2;
       

        public int N1 { get => n1; set => n1 = value; }
        public int N2 { get => n2; set => n2 = value; }

        public partial void calcla();
        
    }
}
