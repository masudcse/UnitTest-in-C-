using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class EmployeeSalary
    {
        public double GetSalary(int grade)
        {
            if(grade == 0)
                 throw new DivideByZeroException();
            else if (grade > 0 && grade <= 2)
            {
                return 8000;
            }
            else if (grade >= 3 && grade <= 5)
            {
                return 10000;
            }
            else
                return 14000;
        }
    }
}
