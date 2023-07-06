using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConcepts
{
    internal class cls1
    {
        private int age;

        public cls1(int va)
        {
          this.Age = va;
           
        }
      
       

        public int Age { get => age; set => age = value; }
        public void dis()
        {
            Console.WriteLine(this.Age);
        }
    }
}
