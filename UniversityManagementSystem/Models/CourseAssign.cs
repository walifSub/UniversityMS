using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class CourseAssign
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int  TeacherId { get; set; }
        public decimal RemainingCredit { get; set; }
        public int CourseId { get; set; }

        public CourseAssign()
        {
        }

        public CourseAssign(int id, int departmentId, int teacherId, decimal remainingCredit, int courseId)
        {
            Id = id;
            DepartmentId = departmentId;
            TeacherId = teacherId;
            RemainingCredit = remainingCredit;
            CourseId = courseId;
        }
    }
}