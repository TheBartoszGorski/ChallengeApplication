using System;
using ChallengeApplication;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("Adam", "Mickiwicz");

        employee.AddGrade("3");
        employee.AddGrade(41);
        employee.AddGrade(34.5f);
        employee.AddGrade(16);

        List<Statistics> employeeStatistics = new List<Statistics>();

        employeeStatistics.Add(employee.GetStatisticsWithForeach());
        employeeStatistics.Add(employee.GetStatisticsWithFor());
        employeeStatistics.Add(employee.GetStatisticsWithWhile());
        employeeStatistics.Add(employee.GetStatisticsWithDoWhile());

        string[] methods = new string[4] { "Foreach", "For", "While", "DoWhile" };

        int iteration = 0;
        foreach (Statistics statistics in employeeStatistics)
        {
            Console.WriteLine(methods[iteration]);
            Console.WriteLine($"Average: {statistics.Average:N2}");
            Console.WriteLine($"Min: {statistics.Min}");
            Console.WriteLine($"Max: {statistics.Max}");
            Console.WriteLine();
            iteration++;
        }
    }
}

