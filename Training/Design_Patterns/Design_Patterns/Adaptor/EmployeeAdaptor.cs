using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    internal class EmployeeAdaptor : IEmployeedetails
    {
        private Employee employee;

        public EmployeeAdaptor(Employee employee)
        {
            this.employee = employee;
        }

        public string? GetName()
        {
            return employee.Name;
        }

        public string? GetPosition()
        {
            return employee.JobTitle;
        }

        public decimal GetSalary()
        {
            return employee.Salary;
        }

    }
}
