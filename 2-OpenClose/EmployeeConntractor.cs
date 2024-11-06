using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    internal class EmployeeConntractor : Employee
    {
        public EmployeeConntractor(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public override decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 20000M;
            decimal salary = hourValue * HoursWorked;

            return salary;
        }
    }
}
