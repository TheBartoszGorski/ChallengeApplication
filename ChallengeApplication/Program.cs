// Exercise 6
using ChallengeApplication;

Employee employee1 = new Employee("Arek", "Hlipała", 23);
Employee employee2 = new Employee("Jarek", "Kaczkowski", 40);
Employee employee3 = new Employee("Andrzej", "Twardowski", 31);

List<Employee> listOfEmployees = new List<Employee>();

listOfEmployees.Add(employee1);
listOfEmployees.Add(employee2);
listOfEmployees.Add(employee3);

Random randomize = new Random();

//Give each employee in the list 5 random grandes in range [1 10]
for (int i = 0; i < 5; i++)
{
    foreach (Employee employee in listOfEmployees)
    {
        employee.AddGrade(randomize.Next(1, 11));
    }
}

DisplayEmployeesGradeSums(listOfEmployees);

List<int> indexesOfBestEmployees = GetIndexesOfBestEmployees(listOfEmployees);

if (indexesOfBestEmployees.Count == 1)
{
    Console.WriteLine("Employee of the month:");
}
else
{
    Console.WriteLine("Employees of the month:");
}

foreach (int index in indexesOfBestEmployees)
{
    listOfEmployees[index].DisplayEmployeeInformation();
}

List<int> GetIndexesOfBestEmployees(List<Employee> employeeList)
{
    int bestEmployeeScore = 0;
    
    foreach (Employee employee in listOfEmployees)
    {
        if (employee.GetGradeSum() > bestEmployeeScore)
        {
            bestEmployeeScore = employee.GetGradeSum();
        }
    }

    int counter = 0;
    List<int> indexesOfBestEmployees = new();

    foreach (Employee employee in listOfEmployees)
    {
        if (employee.GetGradeSum() == bestEmployeeScore)
        {
            indexesOfBestEmployees.Add(counter);
        }

        counter++;
    }

    return indexesOfBestEmployees;
}
void DisplayEmployeesGradeSums(List<Employee> employeeList)
{
    foreach (Employee employee in listOfEmployees)
    {
        Console.WriteLine($"Employee {employee.Name} {employee.Surname} grade sum :{employee.GetGradeSum()}");
    }
}

