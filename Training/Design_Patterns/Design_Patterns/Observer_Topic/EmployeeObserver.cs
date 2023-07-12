using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Topic
{
    internal class EmployeeObserver : IEmployeeObserver
    {
        public void Update(Employee employee)
        {
            Console.WriteLine("Employee Details Updated");
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Department: {employee.Department}");
            Console.WriteLine($"Position: {employee.Position}");
            Console.WriteLine($"Salary: {employee.Salary}");
            Console.WriteLine();
        }

    }
}
