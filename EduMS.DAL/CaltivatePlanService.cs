using EduMS.Models;
using EduMS.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.DAL
{
    public class CaltivatePlanService:BaseService<CaltivatePlan>,ICaltivatePlanService
    {
        public CaltivatePlanService()
            : base(new EduContext())
        {

        }
    }
}
