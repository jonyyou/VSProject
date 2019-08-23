using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EduMS.MVCSite.Models.Admin
{
    public class TeacherViewModel
    {
        [Required, StringLength(10)]    ///required表明该项用户必须填写
        [Display(Name = "教师ID")]
        public string TeaId { get; set; }

        [Required, StringLength(10)]
        [Display(Name = "教师姓名")]
        public string TeaName { get; set; }

        [Required]
        [Display(Name = "性别")]
        public string TeaGender { get; set; }

        [Required, StringLength(11)]
        [Display(Name = "电话号码")]
        public string TeaTele { get; set; }

        [StringLength(18)]
        [Display(Name = "身份证号")]
        public string TeaIDNumber { get; set; }

        [Required, StringLength(12)]
        [Display(Name = "密码")]
        public string Teapwd { get; set; }

        [Required, StringLength(12)]
        [Display(Name = "院系")]
        public string TeaDepartment { get; set; }
    }
}
