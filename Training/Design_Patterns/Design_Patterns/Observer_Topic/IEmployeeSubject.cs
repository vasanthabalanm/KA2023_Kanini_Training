using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Topic
{
    internal interface IEmployeeSubject
    {
        void Attach(IEmployeeObserver observer);
        void Detach(IEmployeeObserver observer);
        void Notify();

    }
}
