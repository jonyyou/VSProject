///业务逻辑层，实现IBLL
///班级

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduMS.Dto;
using EduMS.IBLL;
using EduMS.DAL;
using EduMS.Models;
using System.Data.Entity;

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

        public async Task<List<OriginClassDto>> GetAllOriginClasses()
        {
            using (IDAL.IOriginClassService originClassService = new OriginClassService())
            {
                return await originClassService.GetAllAsync().Select(m => new Dto.OriginClassDto()
                {
                    DepartmentId = m.DepartmentId,
                    DepartmentName = m.Department.DepartmentName,
                    ClassId = m.ClassId,
                    ClassName = m.ClassName,
                    MonitorId = m.MonitorId
                    
                }).ToListAsync();
            }
        }

        public async Task<List<StudentInfoDto>> GetAllStudents(string classId)
        {
            using (IDAL.IStudentService studentService = new StudentService())
            {
                return await studentService.GetAllAsync().Where(m => m.ClassId == classId).Select(m => new Dto.StudentInfoDto()
                {
                    DepartmentName = m.Department.DepartmentName,
                    StuId = m.StuId,
                    StuName = m.StuName,
                    Gender = m.Gender,
                    Telephone = m.Telephone,
                    IDNumber = m.IDNumber,
                    Major = m.Major
                }).ToListAsync();
            }
        }
    }
}
