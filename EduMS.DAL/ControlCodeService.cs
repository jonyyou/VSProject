using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduMS.IDAL;
using EduMS.Models;

namespace EduMS.DAL
{
    public class ControlCodeService:BaseService<Models.ControlCode>, IControlCodeService
    {
        public ControlCodeService()
            :base(new EduContext())
        {

        }
    }
}
