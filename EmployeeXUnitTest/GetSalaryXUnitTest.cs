using Employee;

namespace EmployeeXUnitTest
{
    public class GetSalaryXUnitTest
    {
        private EmployeeSalary _employeeSalary { get; set; } = null;
        public GetSalaryXUnitTest()
        {
            _employeeSalary = new EmployeeSalary();
        }
        [Fact]
        public void GetSalaryByGradeXUnit()
        {
            //Arrange

            var grade = 5;

            //Act
            var result = _employeeSalary.GetSalary(grade);

            //Assert
            Assert.Equal(10000, result);
        }

        [Theory]
       // [InlineData(0, 8000)]
        [InlineData(1, 8000)]
        [InlineData(2, 8000)]
        [InlineData(6, 14000)]
        public void GetSalarybyGradeParameter(int x, double expected)
        {
            //Arrange

            //Act
            var result = _employeeSalary.GetSalary(x);
            //Assert
            Assert.Equal(expected, result);
        }


    }
}