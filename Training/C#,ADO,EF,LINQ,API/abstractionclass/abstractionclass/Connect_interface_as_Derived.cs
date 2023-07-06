using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractionclass
{
    internal class Connect_interface_as_Derived : add1Inter
    {
        public int intadd(int n1,int n2)
        {
            return n1 + n2;
            //throw new NotImplementedException();
        }

        public string stradd( string s1, string s2)
        {
            return s1 + s2;
            //throw new NotImplementedException();
        }
    }
}
