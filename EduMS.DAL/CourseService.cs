using EduMS.IDAL;
using EduMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.DAL
{
    public class CourseService: BaseService<Models.Course>,ICourseService
    {
        public CourseService()
            : base(new EduContext())
        {

        }
    }
}
