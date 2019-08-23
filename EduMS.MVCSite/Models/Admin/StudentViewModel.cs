using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EduMS.MVCSite.Models.Admin
{
    public class StudentViewModel
    {
        [Required]
        [Display(Name = "院系ID")]
        public string DepartmentId { get; set; }

        [Required]
        [Display(Name = "班级ID")]
        public string ClassId { get; set; }

        [Required]
        [Display(Name = "专业")]
        public string Major { get; set; }

        [Required, StringLength(12)]
        [Display(Name = "学号")]
        public string StuId { get; set; }


        [Required, StringLength(30)]
        [Display(Name = "姓名")]
        public string StuName { get; set; }


        [Required]
        [Display(Name = "性别（男/女）")]
        public string Gender { get; set; }


        [Required, StringLength(11)]
        [Display(Name = "联系方式")]
        public string Telephone { get; set; }


        [Required, StringLength(18)]
        [Display(Name = "身份证号")]
        public string IDNumber { get; set; }

        [Required, StringLength(12, MinimumLength = 6)]
        [Display(Name = "密码")]
        public string Pwd { get; set; }

    }
}