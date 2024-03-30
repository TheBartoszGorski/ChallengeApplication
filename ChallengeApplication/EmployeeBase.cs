using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApplication
{
    public abstract class EmployeeBase : IEmployee
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public EmployeeBase()
        {
            this.Name = "";
            this.Surname = "";
        }

        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public abstract void AddGrade(char grade);

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(string grade);


        public abstract void AddGrade(int grade);

        public abstract void AddGrade(long grade);

        public abstract Statistics GetStatistics();

    }
}
