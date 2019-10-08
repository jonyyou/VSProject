using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.Models
{
    public class ControlCode:BaseEntity
    {
        [Required]
        [MaxLength(1)]
        public string IfSelectCourse { get; set; }
    }
}
