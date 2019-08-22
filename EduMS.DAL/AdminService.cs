///管理人员

using EduMS.IDAL;
using EduMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.DAL
{
    public class AdminService : BaseService<Models.Admin>, IAdminService
    {
        public AdminService()
            : base(new EduContext())
        {

        }
    }
}
