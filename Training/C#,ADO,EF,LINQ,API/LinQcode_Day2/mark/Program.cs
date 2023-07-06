using System;

namespace mark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Marks Calculation");
            Console.WriteLine("Enter the Mark1 : ");
            int m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Mark2: ");
            int m2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Mark3: ");
            int m3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Mark4: ");
            int m4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Mark5: ");
            int m5 = int.Parse(Console.ReadLine());

            int total = m1 + m2 + m3 + m4 + m5;
            Console.WriteLine("the total is" + total);
            int average = total /5;
            Console.WriteLine("the averageis" + average);
            if (average > 50) {
                Console.WriteLine("you have passed" + average);
            }
            else
            {
                Console.WriteLine("you have failed" + average +"is your average");
            }
        }
    }
}

