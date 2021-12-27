using System;
using System.Collections.Generic;
using System.Text;

namespace SetApp2.Entities
{
    class Professor
    {
        public string Name { get; set; }
        public HashSet<Course> Courses { get; set; } = new HashSet<Course>();
        

        public Professor(string name)
        {
            Name = name;
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            Courses.Remove(course);
        }

        public int NumberOfStudents()
        {
            if(Courses.Count == 0)
            {
                return 0;
            } else
            {
                HashSet<Student> totalStudents = new HashSet<Student>();
                foreach (Course course in Courses)
                {
                    foreach(Student student in course.Students)
                    {
                        if (!totalStudents.Contains(student))
                        {
                            totalStudents.Add(student);
                        }
                    }
                }
                return totalStudents.Count;
            }
            
        }

        public HashSet<Course> GetAllCourses()
        {
            return Courses;
        }
    }
}
