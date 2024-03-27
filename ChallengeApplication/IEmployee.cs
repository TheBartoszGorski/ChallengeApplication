using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApplication
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        void AddGrade(char grade);
        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(int grade);
        void AddGrade(long grade);
        Statistics GetStatistics();
    }
}
