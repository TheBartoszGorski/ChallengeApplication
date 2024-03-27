using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApplication
{
    public class Employee : Person
    {
        public List<float> grades = new List<float>();
        public Employee() : base()
        {

        }

        public Employee(string name, string surname) : base(name, surname)
        {

        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                case 'F':
                case 'f':
                    this.AddGrade(0);
                    break;
                default:
                    throw new ArgumentException("Given symbol is outside the grading scope.");
            }
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
    }
}
