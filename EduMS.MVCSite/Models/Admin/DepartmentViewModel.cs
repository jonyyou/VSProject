using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EduMS.MVCSite.Models.Admin
{
    public class DepartmentViewModel
    {
        [Required,StringLength(8)]
        [Display(Name ="院系ID")]
        public string DepartmentId { get; set; }

        [Required, StringLength(20)]
        [Display(Name = "院系名称")]
        public string DepartmentName { get; set; }
    }
}