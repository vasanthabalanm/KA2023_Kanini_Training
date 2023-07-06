using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractQues
{
    internal class DrvdCls : samePrnt,Interface1
    {
        public DrvdCls():base() 
        {
            
        }
        public void drvd()
        {
            Console.WriteLine("This is derived class");
        }
        public void name()
        {
            Console.WriteLine("This is an interface consider as base class");
        }
        

    }
}
