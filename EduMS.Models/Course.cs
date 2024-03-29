﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.Models
{
    public class Course:BaseEntity
    {
        [Required, Key, StringLength(8), Column(TypeName = "varchar")]
        public string CourseId { get; set; }

        [Required, StringLength(20)]
        public string CourseName { get; set; }

        [Required]
        public double Credits { get; set; }    //学分

        [Required]
        public int Hours { get; set; }      //学时

        [Required]
        public string CourseSpecialty { get; set; }   //选修课，必修课 

        public string Description { get; set; }

        public virtual ICollection<Enrollment> Enrollment { get; set; }  //选课信息

    }
}
