using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConcepts
{
    abstract class AbstractionClasses
    {
        public abstract void meathod1();

        
    }
    class chldFor:AbstractionClasses
    {
        public override void meathod1()
        {
            Console.WriteLine("this is abstract meathod");
        }
    }
   
}
