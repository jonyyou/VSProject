using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EduMS.MVCSite.Models.Admin
{
    public class OriginClassViewModel
    {
        [Required, StringLength(10)]
        [Display(Name ="班级ID")]
        public string ClassId { get; set; }


        [StringLength(30)]
        [Display(Name = "班级名称，如计科1班")]
        public string ClassName { get; set; }

        [StringLength(12)]
        [Display(Name = "班长学号")]
        public string MonitorId { get; set; }

        [Display(Name = "院系ID")]
        public string DepartmentId { get; set; }
    }
}