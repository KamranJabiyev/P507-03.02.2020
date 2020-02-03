using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Group
    {
        private static int _id = 0;
        public readonly int Id;

        public string Name { get; set; }

        private Student[] Students;

        public Group()
        {
            _id++;
            Id = _id;
            Students = new Student[0];
        }

        public Group(string name) : this()
        {
            Name = name;
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
            //Console.WriteLine($"{Name} Successfully added");
        }
        public void ShowAllStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(student);
            }
        }

        public void ShowStudentById(int id)
        {
            bool hasStudent = false;
            foreach (Student student in Students)
            {
                if(student.Id == id)
                {
                    Console.WriteLine(student);
                    hasStudent = true;
                }
            }

            if(!hasStudent)
            {
                Console.WriteLine("Yoxdur");
            }
        }

        public void RemoveStudentById(int id)
        {
            Student[] newStudents = new Student[0];
            int counter = 0;
            foreach (Student student in Students)
            {
                if(student.Id != id)
                {
                    Array.Resize(ref newStudents, newStudents.Length + 1);
                    newStudents[counter++] = student;
                }
            }
            Students = newStudents;
        }
        
    }
}
