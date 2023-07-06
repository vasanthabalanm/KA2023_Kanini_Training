using SingleInherit;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleDerived01 singleDerived01 = new SingleDerived01("hari",21);
            singleDerived01.calc();
            
        }
    }
}