using System;

namespace Questions1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the CustomerName:");
            string customernme = Console.ReadLine();
            Console.WriteLine("Enter the customerAge:");
            int aes = Convert.ToInt32(Console.ReadLine());
            //Customer customer = new Customer(customernme, aes);
            //customer.disp();
            Console.WriteLine("Enter the choices: 1)LoanAccount  2) SavingsAccount");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch) 
            {
                case 1:
                    Console.WriteLine("Enter the LoanAccount");
                    int lact = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the LoanAmount");
                    int lamt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Loantenuriyrs");
                    int ltyr = Convert.ToInt32(Console.ReadLine());
                    LoanAccount loanAccount = new LoanAccount(lact,lamt,ltyr,customernme, aes);
                    loanAccount.loanDisp();
                    break;
                case 2:
                    Console.WriteLine("Enter the AccountNumber:");
                    int ano = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Amount:");
                    int amt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the BranchName:");
                    string bnme = Console.ReadLine();   
                    Console.WriteLine("Enter the IFSC code:");
                    string cod = Console.ReadLine();
                    SavingsAccount savingsAccount = new SavingsAccount(ano,amt,bnme,cod,customernme, aes);
                    savingsAccount.savngDisp();
                    break;
                default:
                    Console.WriteLine("Enter the correct choice either 1 or 2");
                    break;


            }

        }
    }
}
