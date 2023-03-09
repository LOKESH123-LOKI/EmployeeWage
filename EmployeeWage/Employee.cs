using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
   public class Employee
    {
        const int IS_PRESENT = 1, WagePerHour = 20, DailyHours = 8, PartTimeHours = 8, IS_FULLTIME = 1, IS_HALFTIME = 2;
        public void attendance()
        {
            Random random = new Random();
            int variable= random.Next(0,2);
            if (variable == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");

        }
        public void calculateWage()
        {
            int Salary = 0;
          Random random= new Random();
            int variable=random.Next(0,2);
            if (variable == IS_PRESENT)
                Salary = WagePerHour * DailyHours;
            Console.WriteLine("Salary is"+Salary);

               
        }
        public void Parttimewage()
        {
            int Salary = 0;
            Random random = new Random();
            int variable=random.Next(0,3);
            switch (variable)
            {
                case IS_FULLTIME:
                    Salary=WagePerHour * DailyHours;
                    break;
                case IS_HALFTIME:
                    Salary=(WagePerHour/2)  * DailyHours;
                    break;
            }
            Console.WriteLine("Salary is" + Salary);





        }
    }
}
