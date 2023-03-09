using System;
namespace EmployeeWage
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWage");
            Employee employee = new Employee();
            employee.attendance();
            employee.calculateWage();
            employee.Parttimewage();
            employee.wagesformonth();
        }
    }
}