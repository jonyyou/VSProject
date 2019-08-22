///学生

using EduMS.IDAL;
using EduMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.DAL
{
    public class StudentService : BaseService<Models.Student>, IStudentService
    {
        public StudentService()
            : base(new EduContext())
        {

        }
    }
}
