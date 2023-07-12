using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Topic
{
    internal class EmployeeSubject : IEmployeeSubject
    {
        private List<IEmployeeObserver>? observers;
        private Employee? employee;

        public EmployeeSubject()
        {
            observers = new List<IEmployeeObserver>();
        }

        public void Attach(IEmployeeObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IEmployeeObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(employee);
            }
        }

        public void SetEmployeeDetails(Employee newEmployee)
        {
            employee = newEmployee;
            Notify();
        }

    }
}
