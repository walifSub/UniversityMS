using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class Result
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string Grade { get; set; }

        public Result()
        {
        }

        public Result(int id, int studentId, int courseId, string grade)
        {
            Id = id;
            StudentId = studentId;
            CourseId = courseId;
            Grade = grade;
        }
    }
}