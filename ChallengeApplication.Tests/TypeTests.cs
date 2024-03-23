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
            Employee firstEmployee = GetEmployee("A.", "Cwany", 7);
            Employee secondEmployee = GetEmployee("A.", "Cwany", 7);

            //Assert
            Assert.That(firstEmployee, Is.Not.EqualTo(secondEmployee));

        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
