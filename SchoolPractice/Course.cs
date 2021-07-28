using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        public string CourseName { get; set; }
        public int CourseNo { get; set; }
        public string Teacher { get; set; }
        public List<string> EnrolledStudents { get; set; } //Key: student's name, Value: student's ID number

    }
}
