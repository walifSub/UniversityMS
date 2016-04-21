using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Credit { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }
        public int SemesterId { get; set; }

        public Course()
        {
        }

        public Course(int id, string code, string name, decimal credit, string description, int departmentId, int semesterId)
        {
            Id = id;
            Code = code;
            Name = name;
            Credit = credit;
            Description = description;
            DepartmentId = departmentId;
            SemesterId = semesterId;
        }
    }
}