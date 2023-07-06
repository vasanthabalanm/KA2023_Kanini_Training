
using System;
using System.Text.RegularExpressions;
using System.Transactions;
using day2;

namespace day2
{
    /* class fl
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter the number");
                int n = int.Parse(Console.ReadLine());

                int last = n % 10;
                while (n >= 10)
                {
                    n = n / 10;
                }
                int first = n;
                Console.WriteLine("The first digit is" + first);
                Console.WriteLine("the last digit is"+last);


            }
        }
    }*/



    /*class pnz
       {
           static void Main(string[] args)
           {
               Console.WriteLine("Enter the number:");
               int number = int.Parse(Console.ReadLine());
               if (number >= 0)
               {
                   Console.WriteLine("the number is positive");
               }
               else
               {
                   Console.WriteLine("the number is negative");
               }
           }

       }*/

    /*class mul
      {
          static void Main(string[] args)
          {
              int i, n;
              Console.Write(" enter the number : ");
              n = Convert.ToInt32(Console.ReadLine());
              for (i = 1; i <= 10; i++)
              {
                  Console.Write("{0} X {1} = {2} \n", n, i, n * i);
              }
          }
      }

  */
    /*class ids
      {
          static void Main(string[] args)
          {
              Console.WriteLine("enter your personalID :");
              int id = int.Parse(Console.ReadLine());

              Console.WriteLine("enter your Name :");
              string name = Console.ReadLine();
              Console.WriteLine("enter your Age :");
              int age = int.Parse(Console.ReadLine());
              if (age >=18) {
                  Console.WriteLine(name + "with ID" + id + "is eligible to vote");
              }
              else
              {
                  Console.WriteLine(name + "with ID" + id + "is not eligible to vote");
              }
          }
      }*/
    /* class gross
       {
        static void Main(string[] args)
           {
               Console.WriteLine("enter the input basic salary of an employee");
               int basic_salary = int.Parse(Console.ReadLine());
               if(basic_salary <= 10000)
               {
                   int DA = basic_salary*80 / 100;
                   int HRA = basic_salary*20 / 100;
                  int gross =basic_salary + DA + HRA;
                   Console.Write("Gross Salary:" + gross);
               }
               else if(basic_salary>10000 && basic_salary < 20000)
               {
                   int DA = basic_salary * 90/100;
                   int HRA = basic_salary * 25/100;
                   int gross = basic_salary + DA + HRA;
                   Console.Write("Gross Salary:" + gross);
               }
               else if (basic_salary> 20000)
               {
                   int DA = basic_salary * 95 / 100;
                   int HRA = basic_salary * 30 / 100;
                   int gross = basic_salary + DA + HRA;
                   Console.Write("Gross Salary:" + gross);
               }
           }
       }*/
    public class program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            Console.WriteLine(stu.Name);
            Console.WriteLine(stu.Id);
        }
    }
}
