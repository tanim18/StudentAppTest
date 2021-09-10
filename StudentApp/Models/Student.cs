using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "Teacher")]
        public int TeacherId { get; set; }
        public Teacher Teachers { get; set; }
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }
        public string StudentId { get; set; }
        public string Class { get; set; }
        public int Roll { get; set; }
    }
}
