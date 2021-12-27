using SetApp2.Entities;
using System;
using System.Collections.Generic;

namespace SetApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor("Alex Smith");

            Course courseA = new Course("CourseA", professor);
            professor.AddCourse(courseA);
            Course courseB = new Course("CourseB", professor);
            professor.AddCourse(courseB);
            Course courseC = new Course("CourseC", professor);
            professor.AddCourse(courseC);
            int n = 0;
            string studentName;
            int studentId;
            foreach (Course course in professor.Courses)
            {
                Console.WriteLine("How many students for " + course.Name + "?");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("---Students data required---");
                for(int i = 0; i < n; i++)
                {
                    Console.Write("Student " + (i + 1) + "'s name: ");
                    studentName = Console.ReadLine();
                    Console.Write("Student " + (i + 1) + "'s id: ");
                    studentId = int.Parse(Console.ReadLine());
                    course.AddStudent(new Student(studentName, studentId));
                }
            }

            Console.WriteLine(professor.Name + "'s total number of students: " + professor.NumberOfStudents());

        }
    }
}
