using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions1
{
    internal class Customer
    {
        private string customerName;
        private int age;

        public Customer(string customerName, int age)
        {
            this.CustomerName = customerName;
            this.Age = age;
        }

        public string CustomerName { get => customerName; set => customerName = value; }
        public int Age { get => age; set => age = value; }

        public void disp()
        {
            Console.WriteLine(this.CustomerName);
            Console.WriteLine(this.Age);
        }

    }
}
