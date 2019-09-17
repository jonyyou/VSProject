using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.Models
{
    public class NewsCategory:BaseEntity
    {
        [Required,Key]
        public string CategoryId { get; set; }
        [Required,StringLength(20)]
        public string CategoryName { get; set; }
        public virtual ICollection<News> News { get; set; }
    }
}
