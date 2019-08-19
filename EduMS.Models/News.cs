using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.Models
{
    public class News : BaseEntity
    {
        [Required]
        public string Title { get; set; }

        [Column(TypeName = "ntext"), Required]
        public string Content { get; set; }
        public virtual NewsCategory NewsCategory { get; set; }
    }
}
