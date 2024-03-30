using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApplication
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new();
        public EmployeeInMemory()
            : base()
        {
        }
        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(char grade)
        {
            float floatGrade = 0;
            floatGrade = ConvertCharToGrade(grade);
            this.AddGrade(floatGrade);
        }

        public override void AddGrade(float grade)
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

        public override void AddGrade(string grade)
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

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(long grade)
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

        public override Statistics GetStatistics()
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

        private float ConvertCharToGrade(char character)
        {
            switch (character)
            {
                case 'A':
                case 'a':
                    return 100;
                case 'B':
                case 'b':
                    return 80;
                case 'C':
                case 'c':
                    return 60;
                case 'D':
                case 'd':
                    return 40;
                case 'E':
                case 'e':
                    return 20;
                case 'F':
                case 'f':
                    return 0;
                default:
                    throw new ArgumentException("Given symbol is not a valid grade.");

            }
        }
    }
}
