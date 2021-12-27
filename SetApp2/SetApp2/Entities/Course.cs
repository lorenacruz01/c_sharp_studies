using System;
using System.Collections.Generic;
using System.Text;

namespace SetApp2.Entities
{
    class Course
    {
        public string Name { get; set; }
        public Professor ProfessorName { get; set; }
        public HashSet<Student> Students { get; set; } = new HashSet<Student>();

        public Course(string name, Professor professorName)
        {
            Name = name;
            ProfessorName = professorName;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }

        public HashSet<Student> GetAllStudents()
        {
            return Students;
        }
    }
}
