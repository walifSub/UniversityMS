using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }

        public Student()
        {
        }

        public Student(int id, string regNo, string name, string email, string contact, DateTime date, string address, int departmentId)
        {
            Id = id;
            RegNo = regNo;
            Name = name;
            Email = email;
            Contact = contact;
            Date = date;
            Address = address;
            DepartmentId = departmentId;
        }
    }
}