using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApplication
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelagate GradeAdded;

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
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
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
            GetGradesFromFile();
            statistics.CalculateStatistics(grades);

            return statistics;
        }

        private void GetGradesFromFile()
        {
            if (grades.Count > 0)
            {
                grades.Clear();
            }

            if (File.Exists(fileName))
            {
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
            }

            return;
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
