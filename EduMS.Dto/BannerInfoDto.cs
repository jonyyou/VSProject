using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.Dto
{
    public class BannerInfoDto
    {
        public int BannerId { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public string Remark { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
