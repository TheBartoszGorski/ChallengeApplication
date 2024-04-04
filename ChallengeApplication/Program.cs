using System;
using ChallengeApplication;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the employee grading program!");
        Console.WriteLine("========================================");

        var employee = new EmployeeInMemory("Albert", "Kowalski");
        employee.GradeAdded += NotifyOnGradeAddition;
        employee.AddGrade(3);
        employee.AddGrade(5);
        var employeeStatistics = new Statistics();
        employeeStatistics = employee.GetStatistics();
        DisplayStatistics(employeeStatistics);

        void NotifyOnGradeAddition(object sender, EventArgs args)
        {
            Console.WriteLine("Grade has been added.");
        }
    }

    static void DisplayStatistics(Statistics statistics)
    {
        Console.WriteLine($"Total number of grades: {statistics.DataCount}");
        if (statistics.DataCount > 0)
        {
            Console.WriteLine($"Min: {statistics.Min}");
            Console.WriteLine($"Max: {statistics.Max}");
            Console.WriteLine($"Average: {statistics.Average:N2}");
        }
    }
}

