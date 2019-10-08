using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EduMS.MVCSite.Models.Admin
{
    public class CourseViewModel
    {
        [Required, StringLength(8)]
        [Display(Name = "课程ID")]
        public string CourseId { get; set; }

        [Required, StringLength(20)]
        [Display(Name = "课程名")]
        public string CourseName { get; set; }

        [Required]
        [Display(Name = "学分")]
        public double Credits { get; set; }    //学分

        [Required]
        [Display(Name = "学时")]
        public int Hours { get; set; }      //学时

        [Required]
        [Display(Name = "课程性质")]
        public string CourseSpecialty { get; set; }   //0表示选修课，1表示必修课 

        [Display(Name = "描述")]
        public string Description { get; set; }

    }
}