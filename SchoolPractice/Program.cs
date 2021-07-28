using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.

            //new student:

            Student student = new Student() { Name = "Rowan", StudentId = 12345, NumberOfCredits = 1, Gpa = 4.0 };

            List<string> students = new List<string>();
            students.Add(student.Name);

            //new course:

            Course course = new Course() { CourseName = "Robotics", CourseNo = 101, EnrolledStudents = students, Teacher = "Hodgeson" };
            

            //new teacher:

            Teacher teacher = new Teacher() { FirstName = "Joel", LastName = "Hodgeson", Subject = course.CourseName, YearsTeaching = 40 }; 
        }
    }
}
