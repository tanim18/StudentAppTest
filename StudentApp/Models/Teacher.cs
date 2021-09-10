using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Display(Name="Teacher Name")]
        public string TeacherName { get; set; }
        [Display(Name = "Teacher Designation")]
        public int DesignationId { get; set; }
        public Designation Designations { get; set; }
        public List<Student> Students { get; set; }
    }
}
