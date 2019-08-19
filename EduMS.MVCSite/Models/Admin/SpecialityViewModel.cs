using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EduMS.MVCSite.Models.Admin
{
    public class SpecialityViewModel
    {
        [Required, StringLength(8)]
        [Display(Name = "专业ID")]
        public string SpecialityId { get; set; }

        [Required, StringLength(20)]
        [Display(Name = "专业名称")]
        public string SpecialityName { get; set; }

        /// <summary>
        /// 院系外键
        /// </summary>
        [Display(Name = "院系ID")]
        public string DepartmentId { get; set; }
    }
}