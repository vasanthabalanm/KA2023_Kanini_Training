﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    internal class ChangeDepartmentCommand : ICommand
    {
        private Employee employee;
        private string oldDepartment;
        private string newDepartment;

        public ChangeDepartmentCommand(Employee employee, string newDepartment)
        {
            this.employee = employee;
            this.newDepartment = newDepartment;
            oldDepartment = employee.Department;
        }

        public void Execute()
        {
            employee.ChangeDepartment(newDepartment);
        }

        public void Undo()
        {
            employee.ChangeDepartment(oldDepartment);
        }

    }
}
