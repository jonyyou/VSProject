using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EduMS.MVCSite.Models.Admin
{
    public class CaltivatePlanViewModel
    {
        [Display(Name = "学期")]
        [Required]
        public string Semester { get; set; }

        [Display(Name = "院系ID")]
        [Required]
        public string DepartmentId { get; set; }

        [Display(Name = "课程名")]
        [Required]
        public string CourseId { get; set; }
    }
}