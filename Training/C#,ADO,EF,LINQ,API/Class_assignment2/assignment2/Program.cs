using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    /*  class Program1
     {
         static void Main(string[] args)
         {
             Console.WriteLine("enter your name:");
             string name = Console.ReadLine();
             Console.WriteLine("enter your age :");
             int age = int.Parse(Console.ReadLine());
             Console.WriteLine("enter your country :");
             string country = Console.ReadLine();
             Console.WriteLine("welcome" + name + "." + "your age is" + age + "and you are from" + country);


         }
     }
 }*/


    /*  class less
      {
          static void Main(string[] args)
          {
              Console.WriteLine("enter X:");
              int X = int.Parse(Console.ReadLine());
              Console.WriteLine("enter Y:");
              int Y = int.Parse(Console.ReadLine());
              if (X < Y)
              {
                  bool xislessthany = true;
                  Console.WriteLine(xislessthany);
              }
              else
              {
                  bool xisgreaterthany = false;
                  Console.WriteLine(xisgreaterthany);
              }
          }
      }
  }*/
    /* class food
     {
         static void Main(string[] args)
         {
             Console.WriteLine("enter the number of pizza brought:");
             int pizza = int.Parse(Console.ReadLine());
             Console.WriteLine("enter the number of puff brought:");
             int puff = int.Parse(Console.ReadLine());
             Console.WriteLine("enter the number of pepsi brought:");
             int pepsi = int.Parse(Console.ReadLine());

             int cpizza = 1000 * pizza;
             Console.WriteLine("the cost of pizza is" + cpizza);
             int cpuff = 240 * puff;
             Console.WriteLine("the cost of puff is" + cpuff);
             int cpepsi = 240 * pepsi;
             Console.WriteLine("the cost of pepsi is" + cpepsi);
             int total = cpepsi + cpizza + cpuff;
             Console.WriteLine("the total cost is" + total);
         }
     }
 }*/
    /*  class dt
      {

          static void Main(string[] args)
          {
              sbyte number = 125;
              Console.WriteLine("the number :"+number);
              number = sbyte.MaxValue;
              Console.WriteLine("largest value" + number);
          }
      }*/
    public class sc
    {
        public static double FindSquare(double num)
        {
            double square = num * num;
            return square;
        }
        public static double FindCube(double num)
        {
            double cube = num * num * num;
            return cube;
        }
        public static void Main()
        {
            Console.Write("Enter a number: ");
            double num = double.Parse(Console.ReadLine());
            double sq = FindSquare(num);
            double cu = FindCube(num);
            Console.WriteLine("square of{0} is {1}", num, sq);
            Console.WriteLine("cube of{0} is {1}", num, cu);
        }

    }
}
