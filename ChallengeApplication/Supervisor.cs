using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApplication
{
    public class Supervisor : IEmployee
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<float> grades = new List<float>();
        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
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
                    throw new ArgumentException("Given symbol is not a valid grade.");

            }

        }

        public void AddGrade(float grade)
        {
            if (grade >= -5 && grade <= 105)
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
            if (grade.Length == 1)
            {
                float resultFloat;
                if (float.TryParse(grade, out resultFloat))
                {
                    float gradeValue;
                    gradeValue = ConvertFloatToGrade(resultFloat);
                    this.AddGrade(gradeValue);
                }
                else
                {
                    throw new ArgumentException("Wrong grade string format!");
                }
            }
            else if (grade.Length == 2)
            {
                float plusOrMinusValue = 0;
                float gradeValue = 0;
                int digitsInGrade = 0;
                for (int i = 0; i < grade.Length; i++)
                {
                    if (grade[i] == '+')
                    {
                        plusOrMinusValue = 5;
                    }
                    else if (grade[i] == '-')
                    {
                        plusOrMinusValue = -5;
                    }
                    else
                    {
                        if (float.TryParse(grade.Substring(i, 1), out float resultFloat))
                        {
                            gradeValue = ConvertFloatToGrade(resultFloat);
                            digitsInGrade++;
                        }
                        else
                        {
                            throw new ArgumentException("Wrong grade string format!");
                        }
                    }
                }

                if (digitsInGrade < 2)
                {
                    this.AddGrade(gradeValue + plusOrMinusValue);
                }
                else 
                {
                    throw new ArgumentException("Wrong grade string format!");
                }
            }
            else
            {
                throw new ArgumentException("Wrong grade string format!");
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

        private float GetGradeSum()
        {
            float sum = 0;

            foreach (var grade in grades)
            {
                sum += grade;
            }

            return sum;
        }

        private float ConvertFloatToGrade(float numberToConvert)
        {
            if (numberToConvert > 0 && numberToConvert < 7)
            {
                numberToConvert = numberToConvert * 20 - 20;
            }
            else
            {
                throw new Exception("Wrong grade string format!");
            }

            return numberToConvert;
        }
    }
}
