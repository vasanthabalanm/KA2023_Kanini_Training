using ExecutionAll;
using System;
using System.Diagnostics;

namespace ExecutionAll // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter the chicken count:");
            int chicken = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the cows count:");
            int cows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Pigs count:");
            int pigs = Convert.ToInt32(Console.ReadLine());
            BaseFarmer baseFarmer =new BaseFarmer(chicken,cows,pigs);
            Console.WriteLine("The total number of legs in their farmlands is:"+ baseFarmer.LegsCount());*/


            /*2.
            Console.WriteLine("Enter the Matches wins:");
            int wins =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Draws wins:");
            int drwas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Losses wins:");
            int losses = Convert.ToInt32(Console.ReadLine());
            if(wins >=0 && drwas>=0 && losses>=0) 
            {
                Football football = new Football(wins, drwas, losses);
                Console.WriteLine("The number of points scored by football team is:"+ football.scores());
            }
            else
            {
                Console.WriteLine("Enter numbers must be greater than or equal to zero");
            }*/

            //3.
            //Jadded2D jadded2D = new Jadded2D();
            //jadded2D.display();
            //jadded2D.disp();


            //LambdaLE lambdaLE = new LambdaLE();
            //lambdaLE.evennums();


            /*Console.WriteLine("Enter the prob:");
            double probs = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Prize:");
            int prze = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Pay:");
            int pays = Convert.ToInt32(Console.ReadLine());

            ProfitableGaming profitable = new ProfitableGaming(probs,prze,pays);
            bool res = profitable.calc();
            Console.WriteLine(res);*/

            //4
            /*Console.WriteLine("Enter the Stackboxes:");
            int count = Convert.ToInt32(Console.ReadLine());
            Cubes cubes = new Cubes(count);
            Console.WriteLine("The answer is:" +cubes.squares());*/

            //5
            /*Console.WriteLine("Enter the age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the breaktime");
            bool breaktime = Convert.ToBoolean(Console.ReadLine());

            BarTender bartender = new BarTender();
            Console.WriteLine(bartender.ShouldServeDrinks(age, breaktime));*/

            //6
            /*Console.WriteLine("Enter the cup count");
            int cup = Convert.ToInt32(Console.ReadLine());
            Cofee cofee = new Cofee();
            Console.WriteLine("Total Number of cups : " + cofee.TotalCups(cup));*/

            //7

            //8
            Console.WriteLine("Enter the number of switches");
            int num = Convert.ToInt32(Console.ReadLine());
            Switchs switchs = new Switchs();
            Console.WriteLine(switchs.PosCom(num));

        }

    }
}
}