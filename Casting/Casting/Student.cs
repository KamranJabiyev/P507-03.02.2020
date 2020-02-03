using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Student
    {
        private static int _id=0;
        public readonly int Id;
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student()
        {
            _id++;
            Id = _id;
        }

        public Student(string name,string surname):this()
        {
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
