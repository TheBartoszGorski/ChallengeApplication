namespace ChallengeApplication.Tests
{
    public class TypeTests
    {
        [Test]
        public void ComparisonOfTwoValueTypes()
        {
            //Arrange
            int firstNumber = 5;
            int secondNumber = 5;

            //Assert
            Assert.That(firstNumber, Is.EqualTo(secondNumber));
        }

        [Test]
        public void ComparisonOfTwoStrings()
        {
            //Arrange
            string firstString = "Biedronka";
            string secondString = "Biedronka";

            //Assert
            Assert.That(firstString, Is.EqualTo(secondString));

        }

        [Test]
        public void ComparisonOfTwoReferenceTypes()
        {
            //Arrange
            EmployeeInMemory firstEmployee = GetEmployee("A.", "Cwany");
            EmployeeInMemory secondEmployee = GetEmployee("A.", "Cwany");

            //Assert
            Assert.That(firstEmployee, Is.Not.EqualTo(secondEmployee));

        }

        private EmployeeInMemory GetEmployee(string name, string surname)
        {
            return new EmployeeInMemory(name, surname);
        }
    }
}
