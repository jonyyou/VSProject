using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduMS.IDAL;
using EduMS.Models;

namespace EduMS.DAL
{
    public class NewsService:BaseService<Models.News>,INewsService
    {
        public NewsService()
            : base(new EduContext())
        {

        }
    }
}
