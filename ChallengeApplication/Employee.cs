using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApplication
{
    public class Employee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }

        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void AddGrade(float grade)
        {
            if (grade > 100)
            {
                grades.Add(100);
            }
            else if (grade < 0)
            {
                grades.Add(0);
            }
            else
            {
                grades.Add(grade);
            }
        }

        public float GetGradeSum()
        {
            float sum = 0;

            foreach (var grade in grades)
            {
                sum += grade;
            }

            return sum;
        }

        public Statistics GetStatistics()
        {
            Statistics statistics = new Statistics();
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            foreach (float grade in grades)
            {
                if (grade < statistics.Min)
                {
                    statistics.Min = grade;
                }

                if (grade > statistics.Max)
                {
                    statistics.Max = grade;
                }
            }
            statistics.Average = this.GetGradeSum() / grades.Count;

            return statistics;
        }
        public void DisplayEmployeeInformation()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Employee score: {this.GetGradeSum()}");
        }
    }
}
