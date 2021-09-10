using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Models
{
    public class Designation
    {
        public int Id { get; set; }
        [Display(Name="Designation Name")]
        public string DesignationName { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
