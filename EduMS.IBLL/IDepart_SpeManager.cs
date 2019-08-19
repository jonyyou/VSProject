using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMS.IBLL
{
    public interface IDepart_SpeManager
    {
        Task AddDepartment(string departmentId, string departmentName);
        //Task DeleteDepartment(string departmentId);
        Task AddSpeciality(string SpecialityId, string specialityName, string departmentId);
    }
}
