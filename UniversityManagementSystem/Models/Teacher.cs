using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int DesignationId { get; set; }
        public int DepartmentId { get; set; }
        public decimal CreditTaken { get; set; }

        public Teacher()
        {
        }

        public Teacher(int id, string name, string address, string email, int designationId, int departmentId, decimal creditTaken)
        {
            Id = id;
            Name = name;
            Address = address;
            Email = email;
            DesignationId = designationId;
            DepartmentId = departmentId;
            CreditTaken = creditTaken;
        }
    }
}