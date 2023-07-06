using System;
using classes;
namespace day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 emp = new Class1();

            Console.WriteLine("Enter the Details of the Emloyee");
            Console.WriteLine("Enter the Emplyee ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Department :");
            string dept = (Console.ReadLine());
            Console.WriteLine("Enter the Salary:");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the BonusAmount:");
            int bonus = Convert.ToInt32(Console.ReadLine());
            Class1 emp1 = new Class1(id, name, dept, salary, bonus);

            //emp.Class1(id, name, dept, salary, bonus);
            emp1.display();
        }

    }
}