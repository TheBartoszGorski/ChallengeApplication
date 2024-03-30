using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApplication
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        private List<float> grades = new();

        public Employee()
        {
            this.Name = "";
            this.Surname = "";
        }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void AddGrade(char grade)
        {
            float floatGrade = 0;
            floatGrade = ConvertCharToGrade(grade);
            this.AddGrade(floatGrade);
        }

        public void AddGrade(float grade)
        {
            if (grade > 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException("The grade cannot be lower than 0 or higher than 100.");
            }
        }

        public void AddGrade(string grade)
        {
            float resultFloat;
            char resultChar;
            if (float.TryParse(grade, out resultFloat))
            {
                this.AddGrade(resultFloat);
            }
            else if (char.TryParse(grade, out resultChar))
            {
                this.AddGrade(resultChar);
            }
            else
            {
                throw new ArgumentException("Wrong string format.");
            }

        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(long grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
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
            statistics.DataCount = grades.Count;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            foreach (float grade in grades)
            {
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Max = Math.Max(statistics.Max, grade);
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

        private float ConvertCharToGrade(char character)
        {
            switch (character)
            {
                case 'A':
                case 'a':
                    return 100f;
                case 'B':
                case 'b':
                    return 80f;
                case 'C':
                case 'c':
                    return 60f;
                case 'D':
                case 'd':
                    return 40f;
                case 'E':
                case 'e':
                    return 20f;
                case 'F':
                case 'f':
                    return 0f;
                default:
                    throw new ArgumentException("Given symbol is not a valid grade.");

            }
        }
    }
}

