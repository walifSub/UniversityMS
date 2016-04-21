using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class AllocateClassRoom
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int CourseId { get; set; }
        public int RoomNoId { get; set; }
        public string Day { get; set; }
        public string StartClass  { get; set; }
        public string StartClassAmPm { get; set; }
        public string EndClass { get; set; }
        public string EndtClassAmPm { get; set; }

        public AllocateClassRoom()
        {
        }

        public AllocateClassRoom(int id, int departmentId, int courseId, int roomNoId, string day, string startClass, string startClassAmPm, string endClass, string endtClassAmPm)
        {
            Id = id;
            DepartmentId = departmentId;
            CourseId = courseId;
            RoomNoId = roomNoId;
            Day = day;
            StartClass = startClass;
            StartClassAmPm = startClassAmPm;
            EndClass = endClass;
            EndtClassAmPm = endtClassAmPm;
        }
    }
}