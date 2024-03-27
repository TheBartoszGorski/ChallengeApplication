using System;
using ChallengeApplication;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the employee grading program!");
        Console.WriteLine("========================================");

        Employee employee = new Employee();
        var employeeStatistics = new Statistics();

        while (true)
        {
            Console.WriteLine("Add a grade for the employee: ");
            var input = Console.ReadLine();
            if (input == "q")
            {
                break;
            }
            else
            {
                try 
                {
                    employee.AddGrade(input);
                }
                catch (Exception ex) 
                {
                    Console.WriteLine($"Exception catched: {ex.Message}");
                }
            }
        }

        employeeStatistics = employee.GetStatistics();
        DisplayEmployeeStatistics(employeeStatistics);
    }

    static void DisplayEmployeeStatistics(Statistics employeeStatistics)
    {
        Console.WriteLine($"Total number of grades: {employeeStatistics.DataCount}");
        if (employeeStatistics.DataCount > 0)
        {
            Console.WriteLine($"Min: {employeeStatistics.Min}");
            Console.WriteLine($"Max: {employeeStatistics.Max}");
            Console.WriteLine($"Average: {employeeStatistics.Average:N2}");
        }
    }
}

