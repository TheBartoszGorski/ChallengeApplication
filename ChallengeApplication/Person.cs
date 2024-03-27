using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApplication
{
    public abstract class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Person()
        {
            this.Name = "";
            this.Surname = "";
        }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
    }
}
