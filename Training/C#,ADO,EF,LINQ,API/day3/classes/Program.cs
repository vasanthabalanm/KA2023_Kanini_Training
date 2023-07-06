using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Class1
    {
        public int Id;
        public string? Name;
        public string? department;
        public int salary;
        public int bonus;

        public int total_salary()
        {
            return salary + bonus;
        }
        public Class1(int Id, string Name, string department, int salary, int bonus)
        {
            Console.WriteLine("Parameterized constructor called called");
            this.Id = Id;
            this.Name = Name;
            this.department = department;
            this.salary = salary;
            this.bonus = bonus;

        }
        public Class1()
        {
            Console.WriteLine("This is default constructor");
        }
        public void display()
        {
            Console.WriteLine($"PersonID:{Id},\n PersonName: {Name},\n Department:{department},\n Monthly Income: {salary} \n Total Salary {total_salary()}");
        }
    }
}