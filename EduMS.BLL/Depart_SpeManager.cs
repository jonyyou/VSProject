using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduMS.IBLL;
using EduMS.Models;

namespace EduMS.BLL
{
    public class Depart_SpeManager : IDepart_SpeManager
    {
        public async Task AddDepartment(string departmentId, string departmentName)
        {
            using (IDAL.IDepartmentService stuSvc = new DAL.DepartmentService())
            {
                await stuSvc.CreateAsync(new Department()
                {
                    ModifyTime = DateTime.Now,
                    DepartmentId = departmentId,
                    DepartmentName = departmentName

                });
            }
        }

        public async Task AddSpeciality(string SpecialityId, string specialityName, string departmentId)
        {
            using (IDAL.ISpecialityService stuSvc = new DAL.SpecialityService())
            {
                await stuSvc.CreateAsync(new Speciality()
                {
                    ModifyTime = DateTime.Now,
                    SpecialityId = SpecialityId,                
                    SpecialityName = specialityName,
                    DepartmentId = departmentId

                }) ;
            }
        }

        
    }
}
