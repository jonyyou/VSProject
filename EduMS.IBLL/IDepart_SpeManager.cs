using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduMS.Dto;

namespace EduMS.IBLL
{
    public interface IDepart_SpeManager
    {
        Task AddDepartment(string departmentId, string departmentName);
        //Task DeleteDepartment(string departmentId);
        Task AddSpeciality(string SpecialityId, string specialityName, string departmentId);
        Task<List<DepartmentInfoDto>> GetAllDepartments();
        Task<List<SpecialityInfoDto>> GetAllSpecialitys(string departmentId);
    }
}
