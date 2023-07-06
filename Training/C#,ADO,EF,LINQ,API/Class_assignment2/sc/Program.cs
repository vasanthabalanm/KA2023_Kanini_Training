using System;

namespace sc // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number:");
            int num =int.Parse(Console.ReadLine());
            Console.WriteLine("the squre of {0} is {1}\n", num, num * num);
        }
    }
}