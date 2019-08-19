using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.Models
{
    public class NewsCategory:BaseEntity
    {
        public string CategoryName { get; set; }
        public virtual ICollection<News> News { get; set; }
    }
}
