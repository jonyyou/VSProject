using EduMS.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.IBLL
{
    public interface IOriginClassManager
    {
        Task AddClass(string departmentId,string classId, string className, string monitorId);
        Task AddStudents(string departmentId, string classId, string stuId, string stuName, string gender, string telephone, string IDNumber, string pwd, string major);
        Task<List<OriginClassDto>> GetAllOriginClasses();
        Task<List<StudentInfoDto>> GetAllStudents(string classId);
    }
}
