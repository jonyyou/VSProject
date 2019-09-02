using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EduMS.MVCSite.Models.Admin
{
    public class NewsCategoryViewModel
    {
        [Required,StringLength(10)]
        public string CategoryName { get; set; }
    }
}