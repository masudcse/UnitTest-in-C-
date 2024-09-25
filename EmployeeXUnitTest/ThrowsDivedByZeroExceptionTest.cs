using Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeXUnitTest
{
    public class ThrowsDivedByZeroExceptionTest
    {
        private EmployeeSalary _employeeSalary { get; set; } = null;
        public ThrowsDivedByZeroExceptionTest()
        {
            _employeeSalary = new EmployeeSalary();
        }
        [Fact]
        public void GetDividedByZeroException()
        {
            //Arrange
            var grade = 0;

            //Act


            //Assert
            Assert.Throws<DivideByZeroException>(() => _employeeSalary.GetSalary(grade));
        }

    }
}
