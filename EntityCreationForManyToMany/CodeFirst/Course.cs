using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public IList<StudentCourse> StudentCourse { get; set; }
    }
}