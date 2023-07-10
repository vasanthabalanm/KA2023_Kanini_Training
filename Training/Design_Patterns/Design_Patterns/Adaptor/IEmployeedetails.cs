using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    internal interface IEmployeedetails
    {
        string? GetName();
        string? GetPosition();
        decimal GetSalary();

    }
}
