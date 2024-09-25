using Employee;

namespace EmployeeTest
{
    public class GetSalaryTest
    {
        private EmployeeSalary _employeeSalary { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            _employeeSalary = new EmployeeSalary();
        }

        [Test]
        public void GetSalaryByGrade()
        {
            //Assign 
            var grade = 4;

            //Action
            var result = _employeeSalary.GetSalary(grade);

            //Assert

            Assert.AreEqual(10000, result);
        }
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void GetSalaryByMultipleGrade(int grade)
        {
            //Assign 
           // var grade = 4;

            //Action
            var result = _employeeSalary.GetSalary(grade);

            //Assert

            Assert.AreEqual(10000, result);
        }
    }
}