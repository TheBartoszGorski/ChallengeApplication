namespace ChallengeApplication.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void SumTheEmployeeGrades()
        {
            //Arrange
            Employee TestEmployee = new Employee("£ukasz", "Michalski");

            //Act
            TestEmployee.AddGrade(7);
            TestEmployee.AddGrade(8);
            TestEmployee.AddGrade(3);

            //assert
            Assert.That(TestEmployee.GetGradeSum(), Is.EqualTo(18));
        }

        [Test]
        public void GetStatisticsShouldReturnCorrectMin()
        {
            //Arrange
            Statistics statistics = new Statistics();
            Employee employee = new Employee("Name", "Surname");

            //Act
            employee.AddGrade(5);
            employee.AddGrade(7);
            employee.AddGrade(3);
            statistics = employee.GetStatistics();

            //Assert
            Assert.That(statistics.Min, Is.EqualTo(3));
            Assert.That(statistics.Max, Is.EqualTo(7));
            Assert.That(statistics.Average, Is.EqualTo(5));

        }

        [Test]
        public void GetStatisticsShouldReturnCorrectMax()
        {
            //Arrange
            Statistics statistics = new Statistics();
            Employee employee = new Employee("Name", "Surname");

            //Act
            employee.AddGrade(5);
            employee.AddGrade(7);
            employee.AddGrade(3);
            statistics = employee.GetStatistics();

            //Assert
            Assert.That(statistics.Min, Is.EqualTo(3));
            Assert.That(statistics.Max, Is.EqualTo(7));
            Assert.That(statistics.Average, Is.EqualTo(5));

        }

        [Test]
        public void GetStatisticsShouldReturnCorrectAverage()
        {
            //Arrange
            Statistics statistics = new Statistics();
            Employee employee = new Employee("Name", "Surname");

            //Act
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);
            statistics = employee.GetStatistics();

            Assert.That(Math.Round(statistics.Average, 2), Is.EqualTo(Math.Round(3.3333, 2)));

        }

    }
}