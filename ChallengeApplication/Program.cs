using System;
using ChallengeApplication;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the employee grading program!");
        Console.WriteLine("========================================");

        Supervisor supervisor = new Supervisor("Albert", "Kowalski");
        var supervisorStatistics = new Statistics();

        while (true)
        {
            Console.WriteLine("Add a grade for the supervisor: ");
            var input = Console.ReadLine();
            if (input == "q")
            {
                break;
            }
            else
            {
                try 
                {
                    supervisor.AddGrade(input);
                }
                catch (Exception ex) 
                {
                    Console.WriteLine($"Exception catched:{ex.Message}");
                }
            }
        }

        supervisorStatistics = supervisor.GetStatistics();
        DisplayStatistics(supervisorStatistics);
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

