using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduMS.Models;
using EduMS.IDAL;

namespace EduMS.DAL
{
    public class BannerService:BaseService<Models.Banner>, IBannerService
    {
        public BannerService()
            :base(new EduContext())
        {

        }
    }
}
