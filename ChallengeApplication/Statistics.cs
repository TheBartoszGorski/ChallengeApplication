using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApplication
{
    public class Statistics
    {
        public int DataCount { get; private set; }
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public float Average { get; private set; }
        public string LetterScore { get; private set; }

        public void CalculateStatistics(List<float> grades)
        {
            DataCount = grades.Count;
            Min = float.MaxValue;
            Max = float.MinValue;

            foreach (float grade in grades)
            {
                Min = Math.Min(Min, grade);
                Max = Math.Max(Max, grade);
            }

            CalculateGradeSum(grades);

            Average = Sum / DataCount;

            CalculateLetterScoreFromFloat(Average);

            return;
        }

        public void DisplayEmployeeStatistics()
        {
            Console.WriteLine($"Total number of grades: {DataCount}");
            if (DataCount > 0)
            {
                Console.WriteLine($"Min: {Min}");
                Console.WriteLine($"Max: {Max}");
                Console.WriteLine($"Average: {Average:N2}");
                Console.WriteLine($"Letter score from average: {LetterScore}");
            }
        }

        private void CalculateGradeSum(List<float> grades)
        {
            Sum = 0;

            foreach (var grade in grades)
            {
                Sum += grade;
            }
        }

        private void CalculateLetterScoreFromFloat(float number)
        {
            switch (number)
            {
                case var value when number >= 80:
                    LetterScore = "A";
                    break;
                case var value when number >= 60:
                    LetterScore = "B";
                    break;
                case var value when number >= 40:
                    LetterScore = "C";
                    break;
                case var value when number >= 20:
                    LetterScore = "D";
                    break;
                default:
                    LetterScore = "E";
                    break;
            }

            return;
        }
    }
}
