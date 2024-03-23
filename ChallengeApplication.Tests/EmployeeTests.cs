namespace ChallengeApplication.Tests
{
    public class Tests
    {
        [Test]
        public void SumTheEmployeeGrades()
        {
            //Arrange
            Employee testEmployee = new Employee("£ukasz", "Michalski", 33);

            //Act
            testEmployee.AddGrade(7);
            testEmployee.AddGrade(8);
            testEmployee.AddGrade(3);

            //assert
            Assert.That(testEmployee.GetGradeSum(), Is.EqualTo(18));
        }

        [Test]
        public void SumTheEmployeeGradesWithNegativeValues()
        {
            //Arrange
            Employee testEmployee = new Employee("£ukasz", "Michalski", 33);

            //Act
            testEmployee.AddGrade(7);
            testEmployee.AddGrade(8);
            testEmployee.AddGrade(-3);

            //assert
            Assert.That(testEmployee.GetGradeSum(), Is.EqualTo(12));
        }


    }
}