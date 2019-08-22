///班级


using EduMS.IDAL;
using EduMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.DAL
{
    public class OriginClassService : BaseService<Models.OriginClass>, IOriginClassService
    {
        public OriginClassService()
            : base(new EduContext())
        {

        }
    }
}
