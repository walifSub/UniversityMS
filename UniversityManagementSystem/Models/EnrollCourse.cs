using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class EnrollCourse
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime Date { get; set; }

        public EnrollCourse()
        {
        }

        public EnrollCourse(int id, int studentId, int courseId, DateTime date)
        {
            Id = id;
            StudentId = studentId;
            CourseId = courseId;
            Date = date;
        }
    }
}