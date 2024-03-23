namespace ChallengeApplication.Tests
{
    public class Tests
    {
        [Test]
        public void SumTheEmployeeGrades()
        {
            //Arrange
            Employee TestEmployee = new Employee("£ukasz", "Michalski", 33);

            //Act
            TestEmployee.AddGrade(7);
            TestEmployee.AddGrade(8);
            TestEmployee.AddGrade(3);

            //assert
            Assert.That(TestEmployee.GetGradeSum(), Is.EqualTo(18));
        }

        [Test]
        public void SumTheEmployeeGradesWithNegativeValues()
        {
            //Arrange
            Employee TestEmployee = new Employee("£ukasz", "Michalski", 33);

            //Act
            TestEmployee.AddGrade(7);
            TestEmployee.AddGrade(8);
            TestEmployee.AddGrade(-3);

            //assert
            Assert.That(TestEmployee.GetGradeSum(), Is.EqualTo(12));
        }


    }
}