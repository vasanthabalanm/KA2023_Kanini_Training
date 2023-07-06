using System;
using TestAssessment;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //1.
            //Ques1 ques1 = new Ques1();
            //ques1.vowel();
            ATM aTM = new ATM();
            aTM.Deposit(1000);
            aTM.Withdraw(200);



            //2.
           /* 
            Company company = new Company();
            Console.WriteLine("Enter the department 1. department1 2.department2");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Departmnt1 departmnt1 = new Departmnt1();
                    departmnt1.BonusD1();
                    break;
                case 2:
                    Departmnt2 departmnt2 = new Departmnt2();
                    departmnt2.BonusD2();
                    break;
                default:
                    Console.WriteLine("Enter the correct choice!..");
                    break;
            }*/


            //3.
            //SpaceStation spaceStation = new DeathStar();
            //spaceStation.FireLaser();

        }
    }
}