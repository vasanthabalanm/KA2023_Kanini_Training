using Observer_Topic;

class Program
{
    static void Main(string[] args)
    {
        EmployeeSubject subject = new EmployeeSubject();
        EmployeeObserver observer = new EmployeeObserver();

        subject.Attach(observer);

        Employee employee1 = new Employee
        {
            Name = "John Doe",
            Department = "Sales",
            Position = "Manager",
            Salary = 5000
        };

        subject.SetEmployeeDetails(employee1);

        Employee employee2 = new Employee
        {
            Name = "Jane Smith",
            Department = "Marketing",
            Position = "Analyst",
            Salary = 4000
        };

        subject.SetEmployeeDetails(employee2);

        subject.Detach(observer);
    }
}

