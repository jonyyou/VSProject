using EduMS.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.IBLL
{
    public interface ITeacherManager
    {
        Task AddTeacher(string teaId, string teaName, string gender, string telephone, string IDNumber, string pwd, string DepartmentId);
        Task<List<TeacherInfoDto>> GetAllTeachers();
    }
}
