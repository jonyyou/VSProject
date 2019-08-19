using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduMS.Models;
using EduMS.IDAL;

namespace EduMS.DAL
{
    public class DepartmentService:BaseService<Models.Department>, IDepartmentService
    {
        public DepartmentService()
            :base(new EduContext())
        {

        }
    }
}
