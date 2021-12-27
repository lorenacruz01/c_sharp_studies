using System;
using System.Collections.Generic;
using System.Text;

namespace SetApp2.Entities
{
    class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }

        public Student(string name, int studentId)
        {
            Name = name;
            StudentId = studentId;
        }

        public override int GetHashCode()
        {
            return StudentId.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Student))
            {
                return false;
            }
            Student other = obj as Student;
            return StudentId.Equals(other.StudentId);
        }

    }
}
