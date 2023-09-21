using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILoggerTraining
{
    public class Person
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} {LastName} {Age} lata";
        }
        public Person(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }
    }
}
