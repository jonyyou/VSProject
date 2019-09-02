using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EduMS.MVCSite.Models.Admin
{
    public class NewsViewModel
    {
        [Required, StringLength(30)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string CategoryName { get; set; }
    }
}