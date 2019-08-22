///业务逻辑层，实现IBLL
///班级

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduMS.IBLL;
using EduMS.Models;

namespace EduMS.BLL
{
    public class OriginClassManager : IOriginClassManager
    {
        public async Task AddClass(string departmentId,string classId, string className, string monitorId)
        {
            using (IDAL.IOriginClassService Svc = new DAL.OriginClassService())
            {
                await Svc.CreateAsync(new OriginClass()
                {
                    DepartmentId = departmentId,
                    ClassId = classId,
                    ClassName = className,
                    MonitorId = monitorId,
                    ModifyTime = DateTime.Now
                }) ;
            }
        }

        public async Task AddStudents(string departmentId, string classId, string stuId, string stuName, string gender, string telephone, string IDNumber, string pwd, string major)
        {
            using (IDAL.IStudentService Svc = new DAL.StudentService())
            {
                await Svc.CreateAsync(new Student()
                {
                    DepartmentId = departmentId,
                    ClassId = classId,
                    StuId = stuId,
                    StuName = stuName,
                    Gender = gender,
                    Telephone = telephone,
                    IDNumber = IDNumber,
                    Pwd = pwd,
                    Major = major,
                    ModifyTime = DateTime.Now
                });
            }
        }
    }
}
