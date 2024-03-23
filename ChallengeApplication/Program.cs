// Exercise 6
using ChallengeApplication;

Employee employee1 = new Employee("Adam", "Mickiwicz");

employee1.AddGrade(3);
employee1.AddGrade(41);
employee1.AddGrade((float)34.5);
employee1.AddGrade(16);

var employeeOneStatistics = new Statistics();
employeeOneStatistics = employee1.GetStatistics();

Console.WriteLine($"Average: {employeeOneStatistics.Average:N2}");
Console.WriteLine($"Min: {employeeOneStatistics.Min}");
Console.WriteLine($"Max: {employeeOneStatistics.Max}");

