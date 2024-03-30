using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApplication
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        private List<float> grades = new();

        public EmployeeInFile()
            : base()
        {
        }
        public EmployeeInFile(string name, string surname)
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
            if (grade > 0 && grade < 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
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

        public override Statistics GetStatistics()
        {
            Statistics statistics = new Statistics();
            if (File.Exists(fileName))
            {
                statistics.Min = float.MaxValue;
                statistics.Max = float.MinValue;

                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        if (line == "")
                        {
                            line = reader.ReadLine();
                            continue;
                        }

                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }

                foreach (float grade in grades)
                {
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Average += grade;
                }

                statistics.DataCount = grades.Count;
                statistics.Average /= grades.Count;
            }

            return statistics;
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
