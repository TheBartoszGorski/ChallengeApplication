namespace ChallengeApplication.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void Employee_GetGradeSum_ShouldReturnCorrectValue()
        {
            //Arrange
            Employee testEmployee = new Employee("£ukasz", "Michalski");

            //Act
            testEmployee.AddGrade(7);
            testEmployee.AddGrade(8);
            testEmployee.AddGrade(3);

            //assert
            Assert.That(testEmployee.GetGradeSum(), Is.EqualTo(18));
        }

        [Test]
        public void GetStatistics_ShouldReturnCorrectMin()
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
        public void GetStatistics_ShouldReturnCorrectMax()
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
        public void GetStatistics_ShouldReturnCorrectAverage()
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

        [Test]
        public void GetStatistics_ShouldInterpretCharGrades()
        {
            //Arrange
            Statistics statistics = new Statistics();
            Employee employee = new Employee();

            //Act
            employee.AddGrade('A');
            employee.AddGrade('b');
            employee.AddGrade(3);
            statistics = employee.GetStatistics();
            Assert.That(statistics.Average, Is.EqualTo(61));
        }

        [Test]
        public void GetStatistics_ShouldInterpretStringGrades()
        {
            //Arrange
            Statistics statistics = new Statistics();
            Employee employee = new Employee();

            //Act
            employee.AddGrade("A");
            employee.AddGrade("b");
            employee.AddGrade(3);
            statistics = employee.GetStatistics();
            Assert.That(statistics.Average, Is.EqualTo(61));
        }
    }
}