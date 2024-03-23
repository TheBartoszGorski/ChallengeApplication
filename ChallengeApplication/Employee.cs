using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApplication
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public List<int> grades = new List<int>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public void AddGrade(int grade)
        {
            if (grade > 10)
            {
                grades.Add(10);
            }
            else if (grade < -10)
            {
                grades.Add(-10);
            }
            else
            {
                grades.Add(grade);
            }
        }

        public int GetGradeSum()
        {
            int sum = 0;

            foreach (var grade in grades)
            {
                sum += grade;
            }

            return sum;
        }

        public void DisplayEmployeeInformation()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Employee score: {this.GetGradeSum()}");
        }
    }
}
