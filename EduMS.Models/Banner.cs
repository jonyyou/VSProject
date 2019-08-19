using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.Models
{
    public class Banner:BaseEntity
    {
        public int BannerId { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public string Remark { get; set; }
    }
}
