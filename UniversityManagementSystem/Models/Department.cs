using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Department()
        {
        }

        public Department(int id, string code, string name)
        {
            Id = id;
            Code = code;
            Name = name;
        }
    }
}