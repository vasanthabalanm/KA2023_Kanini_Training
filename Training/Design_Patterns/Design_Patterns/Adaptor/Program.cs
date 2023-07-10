using Adaptor;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee
        {
            Name = "John Doe",
            JobTitle = "Manager",
            Salary = 5000
        };

        EmployeeAdaptor adapter = new EmployeeAdaptor(employee);

        EmployeeInfo infoPrinter = new EmployeeInfo();
        infoPrinter.PrintEmployeeDetails(adapter);
    }
}
