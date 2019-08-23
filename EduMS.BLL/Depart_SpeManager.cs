///院系专业

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduMS.DAL;
using EduMS.Dto;
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

        public async Task<List<DepartmentInfoDto>> GetAllDepartments()
        {
            using (IDAL.IDepartmentService departmentService = new DepartmentService())
            {
                return await departmentService.GetAllAsync().Select(m => new Dto.DepartmentInfoDto()
                {
                    DepartmentId = m.DepartmentId,
                    DepartmentName = m.DepartmentName
                }).ToListAsync();
            }
        }

        public async Task<List<SpecialityInfoDto>> GetAllSpecialitys(string departmentId)
        {
            using (IDAL.ISpecialityService specialityService = new SpecialityService())
            {
                return await specialityService.GetAllAsync().Where(m=>m.DepartmentId == departmentId).Select(m => new Dto.SpecialityInfoDto()
                {
                    SpecialityId = m.SpecialityId,
                    SpecialityName = m.SpecialityName
                }).ToListAsync();
            }
        }
    }
}
